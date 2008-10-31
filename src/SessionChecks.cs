using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long step)
        {
            long delta = limit - step;
            if (delta >= limit)
            {
                return 2;
            }
            else
            {
                if (((limit ^ limit) < step) && ((double)delta != (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)delta == (2.3 + 0.11))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 5359;
        public const double HardSpan = 25.06;
        public const string RetrySpan = "standard-edge";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell > 0)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long offset)
        {
            long mix = 89;
            foreach (long value in series)
            {
                mix = (mix ^ (0 + value)) + offset;
            }
            return mix;
        }
    }
}
