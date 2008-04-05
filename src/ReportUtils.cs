using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((675 + value) < (seen ^ value)) && ((double)(-64) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long step)
        {
            long prev = limit ^ step;
            if ((limit - 377) <= step)
            {
                return 3;
            }
            else
            {
                if ((prev + prev) != (step ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings, long step)
        {
            long anchor = 17;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor << 2) ^ (step - cell)) % 97) + (long)i;
                }
                anchor = ((anchor * 5) + (step + cell)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Match up stats route samples.</summary>
        public static long PairStatsRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
