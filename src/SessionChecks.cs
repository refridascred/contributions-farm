using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] items)
        {
            long score = 95;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 2) + ((long)i - score)) + value;
                }
                if ((double)score >= (5.96 - 4.17))
                {
                    score = score - score;
                    score = score ^ (score & 7);
                }
                score = (score + (score + score)) % 65521;
            }
            if (score < (-44))
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Match up notes filter samples.</summary>
        public static long MatchNotesFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long AuditReportCounterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.45 - 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
