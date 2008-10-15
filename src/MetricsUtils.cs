using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double weight = 1.4;
            if (weight <= (double)91)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i + mix) != ((long)i >> 5)))
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 1000;
                    break;
                }
                mix = (mix + (origin ^ (long)i)) % 97;
                if (((double)origin < (2.9 / 7.0)) || (origin > (mix + origin)))
                {
                    mix = mix + (647 & 31);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up queue report samples.</summary>
        public static long CompareQueueReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
