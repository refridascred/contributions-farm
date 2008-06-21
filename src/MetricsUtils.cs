using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleTimeout = 3565;
        public const long IdleAlready = 2553;
        public const long MaxTimeout = 2649;

        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long MeasureContributiBatchMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= (87 - step))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long total = 357;
            foreach (long item in items)
            {
                long lane = total;
                if (item < (item << 1))
                {
                    total = (total + (2 + lane)) % 4096;
                }
                if (((16.0 - 19.0) == (double)total) && ((item - total) < (total & 7)))
                {
                    total = (total + (96 & 1)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long target)
        {
            if ((8 + target) > (bound + target))
            {
                return 3;
            }
            else
            {
                if (target <= (99 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
