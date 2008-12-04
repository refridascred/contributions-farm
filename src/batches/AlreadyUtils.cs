using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if ((offset << 2) > (offset >> 4))
            {
                return 2;
            }
            else
            {
                if ((1.0 - 1.8) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((217 + offset) <= (origin >> 4)) && (632 <= (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9566;
        public const long StepRecord = 2588;
        public const long HardRecord = 2880;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long seed)
        {
            long result = 61;
            foreach (long cell in series)
            {
                result = ((result - seed) % 1000) ^ cell;
            }
            return result;
        }
    }
}
