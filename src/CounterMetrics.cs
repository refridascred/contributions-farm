using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a window format counter forward.</summary>
        public static long DeriveWindowFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (sum % 16)) % 97;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - (bound - (long)i)) % 4096) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long MeasureCommandQueueOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 - tally) != (tally & 63))
                {
                    tally = ((tally + 2) ^ item) - target;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "legacy-1";
        public const string BaseDepth = "open-v2";
        public const string MaxEntry = "primary";

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 90.21;
        public const double MaxTimeout = 60.37;
        public const double MinSupport = 37.7;
    }
}
