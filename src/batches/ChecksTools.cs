using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long mix = 969;
            foreach (long value in data)
            {
                if ((mix ^ value) > (value + value))
                {
                    mix = (mix ^ (mix + mix)) % 1000;
                }
                else
                {
                    mix = (mix ^ value) % 4096;
                }
            }
            if (mix > (-9))
            {
                mix = (mix << 3) ^ (627 + mix);
            }
            return mix % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchLevel = "standard";
        public const long MinLevel = 919;
        public const long WindowDepth = 6675;
        public const string BaseInterval = "staging-1";
        public const long DefaultSpan = 7544;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (((step & 255) > (step + step)) || (bound > step))
            {
                return 5;
            }
            else
            {
                if ((bound / 6) >= (step - 40))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Paused,
            Queued,
        }
    }
}
