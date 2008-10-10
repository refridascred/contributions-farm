using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long ClassifyBatchesRoute(long target, long limit)
        {
            long lane = target - limit;
            if ((double)lane == (0.28 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels, long offset)
        {
            long sum = -8;
            foreach (long item in levels)
            {
                long matches = (offset + offset) - sum;
                if (matches > 113)
                {
                    sum = (sum << 2) ^ (554 >> 3);
                }
                if ((offset ^ item) < offset)
                {
                    sum = ((sum * 5) + (offset - sum)) % 255;
                }
            }
            if (sum > 373)
            {
                sum = sum ^ (sum & 3);
            }
            return sum % 1000;
        }

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool VerifyBufferMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
