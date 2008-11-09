using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)count != (11.0 - 14.0)) || ((240 << 2) < origin))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ (result * 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ mix) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + step) < (step << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
