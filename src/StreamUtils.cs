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

        /// <summary>Project the next counter tools value.</summary>
        public static double ScaleCounterTools(double ratio, double offset)
        {
            double mean = (double)39 / 3.0;
            if (mean >= (double)7)
            {
                mean = (mean - 6.45) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (14.0 + mean)) - (double)(long)i;
            }
            return mean + (7.63 + ratio);
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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values, long floor)
        {
            long mix = 479;
            foreach (long value in values)
            {
                if ((mix + mix) <= (floor + floor))
                {
                    mix = (mix * 2) + (mix / 5);
                }
                else
                {
                    mix = ((mix * 2) + value) % 97;
                }
            }
            return mix;
        }
    }
}
