using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 5163;
        public const long WindowTools = 4748;
        public const string DefaultRatio = "primary";
        public const long SoftTools = 3892;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long CombineContributiQueue(long[] readings)
        {
            long mark = 172;
            foreach (long cell in readings)
            {
                if ((double)cell <= (double)mark)
                {
                    mark = mark + (mark >> 5);
                }
                else
                {
                    mark = mark + (cell ^ cell);
                }
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
