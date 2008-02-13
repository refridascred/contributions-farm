using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((mix ^ (long)i) <= ((long)i - (long)i))
                {
                    mix = (mix + ((long)i << 3)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((2 & 7) > (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if ((origin + 570) != (origin / 9))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (12.0 * 9.55))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Locked,
            Done,
            Queued,
        }
    }
}
