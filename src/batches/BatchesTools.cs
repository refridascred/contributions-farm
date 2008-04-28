using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            if (limit <= 4)
            {
                return 0;
            }
            else
            {
                if ((719 + limit) >= (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (limit ^ 19))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 12) <= (95 - limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (floor >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
