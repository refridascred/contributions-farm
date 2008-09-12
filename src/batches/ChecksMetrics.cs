using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            long diff = seed + bound;
            if ((5 + bound) >= (bound / 7))
            {
                return 8;
            }
            else
            {
                if ((double)bound >= 16.0)
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) <= diff)
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

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long TallySchemaSessionOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!!((target << 3) == (target - 9)))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) >= (origin % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next route entry value.</summary>
        public static double ProjectRouteEntry(double ratio, double span)
        {
            double scale = ratio;
            if (scale < scale)
            {
                scale = scale - (double)79;
            }
            else
            {
                scale = scale - (span + 3.9);
            }
            return scale - (double)(-15);
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
