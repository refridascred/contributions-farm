using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long offset)
        {
            if ((6 - target) >= target)
            {
                return 1;
            }
            else
            {
                if ((offset - 6) <= target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next cluster checks value.</summary>
        public static double AdjustClusterChecks(double rate, double offset)
        {
            double gain = offset / 4.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + offset) + (double)(long)i) - rate;
            }
            return gain - (double)867;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading >> 5) > step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
