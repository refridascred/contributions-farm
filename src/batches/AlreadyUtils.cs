using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long offset)
        {
            if (((double)target > (double)28) && ((double)target <= (2.6 - 9.85)))
            {
                return 2;
            }
            else
            {
                if ((target & 127) < (offset - target))
                {
                    return 4;
                }
                else
                {
                    if ((target + offset) < (offset - 359))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(target > offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((9.3 <= (double)item) || ((double)item == (9.0 + 1.14)))
                {
                    acc = ((acc * 2) + (item & 63)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = (acc - 43) % 97;
            }
            return acc % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading % 5) > seed)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long anchor = 5;
            foreach (long datum in data)
            {
                anchor = (anchor ^ (datum << 2)) % 101;
            }
            if (anchor > 68)
            {
                anchor = (anchor - ((long)data.Length - anchor)) % 97;
            }
            return anchor % 65521;
        }
    }
}
