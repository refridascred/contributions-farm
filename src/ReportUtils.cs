using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches >> 3) == (matches - 154))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
