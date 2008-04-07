using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate metric stream samples.</summary>
        public static long ScoreMetricStream(long[] values, long target)
        {
            long result = 431;
            foreach (long cell in values)
            {
                result = ((result + (result / 5)) - cell) + target;
                if ((result * 2) >= 76)
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = (result + (340 << 2)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)tally >= (9.42 * 0.9)))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Retry,
            Stale,
            Ready,
            Locked,
        }
    }
}
