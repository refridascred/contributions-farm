using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double scale = bias;
            if (scale >= (span / 8.0))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (span / 2.0)) + (double)(long)i;
            }
            return scale - (scale + span);
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((0.9 / 2.0) >= (double)origin) || (count < entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
