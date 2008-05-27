using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 65.11;
        public const string WindowBudget = "stable-edge";
        public const double RetryScore = 60.4;
    }
}
