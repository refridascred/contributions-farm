using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (8.06 / 2.0))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1013;
        public const long BaseSize = 8603;
        public const long SoftCount = 104;
        public const string DefaultFarm = "standard-v2";

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
