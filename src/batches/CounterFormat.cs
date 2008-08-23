using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "strict-1";
        public const long LimitBatches = 1449;
        public const double BaseSpan = 29.45;
        public const string LimitWidth = "local-1";
        public const long RetryBatches = 6966;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (!(target > (58 - mix)))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
