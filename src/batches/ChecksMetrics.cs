using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double load = span;
            return (load + 6.5) + rate;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] readings, long step)
        {
            long total = 743;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (entry - entry)) % 255;
                total = (total + (55 % 3)) % 4096;
            }
            if (total > 3)
            {
                total = total ^ step;
            }
            return total;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank metrics stream input into a small class.</summary>
        public static long BucketMetricsStream(long floor, long step)
        {
            if ((45 ^ (-99)) < (step * 3))
            {
                return 0;
            }
            else
            {
                if (((6.0 * 7.1) >= (double)floor) || (step > (floor / 5)))
                {
                    return 4;
                }
                else
                {
                    if ((8.84 * 9.9) <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Stale,
            Closed,
        }
    }
}
