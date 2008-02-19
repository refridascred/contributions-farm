using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up report metrics samples.</summary>
        public static long PairReportMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample / 9) > (sample ^ sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
