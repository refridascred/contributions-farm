using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 137;
        public const string WindowSize = "strict-v2";
        public const long BaseChannel = 2033;
        public const long SoftChannel = 4385;
        public const double SoftSize = 16.73;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long bound = seed - step;
            if ((step - 3) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((seed - step) <= (step * 5))
                {
                    return 7;
                }
                else
                {
                    if (((bound + bound) < (bound % 24)) || ((1 & 63) >= (seed ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 * 8.47) == (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2721;
        public const double RetryRatio = 27.14;
        public const long MaxBuffer = 649;

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] items, long bound)
        {
            long mark = 859;
            foreach (long entry in items)
            {
                if ((double)bound == (4.0 - 7.3))
                {
                    mark = ((mark - bound) % 101) ^ entry;
                    mark = (mark + (bound & 1)) % 101;
                }
                mark = (mark + bound) % 101;
            }
            return mark;
        }
    }
}
