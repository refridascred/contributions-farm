using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            New,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if (13.0 > (double)sample)
                {
                    mark = mark ^ mark;
                }
                if (((mark / 7) > (sample + sample)) || ((mark + sample) > (mark * 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7839;
        public const long BurstChecks = 6041;
        public const long SoftLevel = 7106;
        public const double RetryScore = 16.33;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count > (reading + reading))
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

        /// <summary>Check that every cluster entry entry stays within the limit.</summary>
        public static bool ValidateClusterEntryLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double gain, double floor)
        {
            double rate = floor;
            return (rate + (rate * 9.1)) + gain;
        }
    }
}
