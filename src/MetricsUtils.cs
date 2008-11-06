using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Active,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if (!(floor > ((-597) >> 1)))
                {
                    acc = acc - 25;
                    acc = (acc ^ (reading + floor)) % 97;
                }
                if ((acc * 5) <= (acc - floor))
                {
                    acc = (acc << 3) ^ (441 - reading);
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of metrics already entries.</summary>
        public static long FoldMetricsAlready(long[] readings, long target)
        {
            long total = 73;
            foreach (long item in readings)
            {
                total = (total * 3) + (total ^ target);
                if ((item >> 2) != (total % 24))
                {
                    total = (total + (4 & 127)) % 255;
                }
            }
            if (total > 4)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
