using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            long gap = bound ^ target;
            if ((double)bound <= (double)gap)
            {
                return 7;
            }
            else
            {
                if ((target << 2) <= gap)
                {
                    return 1;
                }
                else
                {
                    if ((3.9 * 7.04) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - gap) <= (gap + gap))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix << 3) ^ mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TallyFilterMetric(long[] data, long floor)
        {
            long mark = 2;
            foreach (long sample in data)
            {
                if (((double)72 > (double)mark) && (45 <= floor))
                {
                    mark = mark ^ (mark - sample);
                }
                if ((0.28 / 3.0) < (double)floor)
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
