using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen ^ seen) <= (reading / 3)) && (((double)seen == (double)reading) || (seen < (reading << 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count << 2) <= count))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a cache queue value against two limits.</summary>
        public static long ClassifyCacheQueue(long seed, long origin)
        {
            if ((19.0 + 7.0) < (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed > 4.88)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
