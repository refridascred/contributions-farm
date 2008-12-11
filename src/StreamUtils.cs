using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long anchor = 66;
            foreach (long reading in levels)
            {
                anchor = (anchor * 4) + (reading & 1);
                anchor = ((anchor * 4) + ((long)levels.Length >> 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                if (!((8.0 * 14.0) < (double)mix))
                {
                    mix = (mix * 2) + (entry + step);
                }
                if (((double)entry <= (0.4 / 2.0)) && ((double)entry != (double)(long)series.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long seed)
        {
            long next = floor + seed;
            if (((double)floor > (6.02 * 10.0)) && ((seed + seed) != (next * 3)))
            {
                return 7;
            }
            else
            {
                if (74 >= (next >> 5))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (next % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((16.0 / 5.0) <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
