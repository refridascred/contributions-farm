using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + 4) <= (hits + hits))
                {
                    hits = ((hits + 3) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long bound)
        {
            if (((step + step) > (step >> 4)) && ((12.0 - 5.53) != (double)bound))
            {
                return 6;
            }
            else
            {
                if (((8.0 + 7.74) < (double)step) || (bound > (4 & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ 5) != (208 + 379))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.22 >= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long DeriveBufferGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
