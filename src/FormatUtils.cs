using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((171 + (-622)) != (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Count window batches pairs that satisfy a relation.</summary>
        public static long CompareWindowBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long offset)
        {
            long lane = floor - offset;
            if ((2.84 - 0.8) < (double)lane)
            {
                return 2;
            }
            else
            {
                if ((7.59 - 2.6) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < 2.2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.12 / 6.0) == (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
