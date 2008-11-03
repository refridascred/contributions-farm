using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((double)offset > 11.0) && ((double)offset > (double)59))
                {
                    sum = (sum * 5) + offset;
                    sum = ((sum * 2) + (sum & 127)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRatio = "standard-v2";
        public const long SoftRoute = 2649;
        public const long WindowSpan = 8394;
        public const string BurstWidth = "stable";
        public const long SoftSize = 759;
    }
}
