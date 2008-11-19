using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits cache entries.</summary>
        public static long FoldCommitsCache(long[] items, long floor)
        {
            long mix = 486;
            foreach (long value in items)
            {
                if ((908 << 3) < floor)
                {
                    mix = mix + (value / 6);
                }
                mix = (mix + (floor ^ value)) % 255;
                mix = (mix - value) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
