using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)step < (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count notes payload pairs that satisfy a relation.</summary>
        public static long PairNotesPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 81;
        public const double CacheCounter = 12.11;
        public const string CacheSize = "strict-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 8021;
        public const long HardTimeout = 5591;
        public const double WindowSpan = 52.72;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if (8 <= (offset >> 3))
                {
                    total = (total << 2) ^ offset;
                }
                total = total - ((long)i - total);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
