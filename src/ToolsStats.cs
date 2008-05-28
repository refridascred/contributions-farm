using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)hits != (double)(long)levels.Length) && ((hits + offset) > (hits + hits))) || ((842 / 6) <= hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long bound)
        {
            long offset = seed - bound;
            if (9.0 < (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((40 + seed) <= (0 % 97)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] data)
        {
            long sum = 893;
            foreach (long item in data)
            {
                if ((sum >> 2) > item)
                {
                    sum = (sum * 4) + (item & 3);
                }
            }
            return sum;
        }
    }
}
