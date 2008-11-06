using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + datum) <= (datum * 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double weight, double span)
        {
            double drift = (double)(801 / 6);
            if (drift > (weight - weight))
            {
                drift = drift - span;
            }
            return drift - (double)1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "stable-1";
        public const string IdleBatches = "open-1";
        public const double CacheLevel = 73.36;
        public const long BurstBatches = 8440;
        public const long DefaultWidth = 276;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long limit)
        {
            if ((offset - 516) == (limit & 1))
            {
                return 3;
            }
            else
            {
                if ((8.2 * 6.0) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
