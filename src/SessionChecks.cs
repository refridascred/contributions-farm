using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long floor)
        {
            if ((5.5 - 9.0) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (4.6 <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels)
        {
            long total = -252;
            foreach (long reading in levels)
            {
                if ((reading >= (total << 1)) || (601 >= total))
                {
                    total = (total + (reading * 2)) % 1000;
                }
                else
                {
                    total = (total - (total * 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long seed2)
        {
            if (seed < (seed2 % 10))
            {
                return 7;
            }
            else
            {
                if ((seed2 * 4) > (seed2 + 277))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) >= seed2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
