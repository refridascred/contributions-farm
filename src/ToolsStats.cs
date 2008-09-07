using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long limit)
        {
            long acc = 44;
            foreach (long cell in readings)
            {
                if ((3.24 + 0.71) >= (double)cell)
                {
                    acc = (acc - (limit ^ 255)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ limit) % 65521;
                }
                acc = ((acc * 2) + (acc * 3)) % 4096;
            }
            if (acc > 391)
            {
                acc = (acc * 5) + (0 + acc);
            }
            return acc % 65521;
        }

        /// <summary>Count notes cache pairs that satisfy a relation.</summary>
        public static long CompareNotesCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long DeriveCacheTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark * 3) + (offset >> 4);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 8254;
        public const string BaseLevel = "legacy-edge";
        public const string CacheSize = "primary-v2";
    }
}
