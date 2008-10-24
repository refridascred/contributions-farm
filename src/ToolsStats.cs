using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double ratio = (double)(4 & 255);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - scale;
            }
            return ratio + floor;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ (42 ^ 441);
                mix = (mix << 3) ^ mix;
                mix = mix + (mix >> 1);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks window readings against a bound.</summary>
        public static bool GuardChecksWindowBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
