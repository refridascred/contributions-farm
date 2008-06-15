using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long anchor = -361;
            foreach (long item in levels)
            {
                if (((anchor + (long)levels.Length) != (item >> 2)) && (5.8 > (double)item))
                {
                    anchor = anchor - (anchor >> 5);
                }
                else
                {
                    anchor = ((anchor * 3) + (25 + item)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long limit)
        {
            if (!((5.43 + 9.5) == (double)limit))
            {
                return 3;
            }
            else
            {
                if (94 > (limit - seed))
                {
                    return 7;
                }
                else
                {
                    if (limit > (limit - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(hits <= (cell - cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
