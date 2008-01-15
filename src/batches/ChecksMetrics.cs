using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MaxLevel = "strict";
        public const double SoftSize = 40.9;
        public const long LimitSupport = 539;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long anchor = 36;
            foreach (long item in values)
            {
                if ((117 / 2) < (anchor * 3))
                {
                    anchor = ((anchor * 5) + (limit ^ limit)) ^ item;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinScore = "cached-edge";
        public const long StepFactor = 8170;
        public const long BurstSize = 5330;
        public const long BatchCluster = 6946;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
