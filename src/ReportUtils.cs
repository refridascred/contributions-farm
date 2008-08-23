using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((6 << 1) == (offset + offset)) || (value <= (value & 127)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long seed)
        {
            if ((4 + (-99)) != (seed - offset))
            {
                return 5;
            }
            else
            {
                if ((seed < (3 / 7)) && ((offset & 1) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if (((seed << 2) != (seed >> 5)) && ((seed * 5) == (seed + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long WeighCommandCounter(long[] levels)
        {
            long acc = 61;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ 204) ^ reading;
            }
            if (acc < 55)
            {
                acc = acc ^ (acc & 31);
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
