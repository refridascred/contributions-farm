using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long seed)
        {
            long result = 94;
            foreach (long item in values)
            {
                result = result - (result * 4);
                if ((seed - result) <= (item - seed))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7766;
        public const long HardToken = 1147;
        public const long RetryTimeout = 4913;
        public const string WindowSize = "open-edge";
        public const double BurstToken = 83.91;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long CompareWindowMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + seed) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
