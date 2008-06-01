using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values)
        {
            long total = 36;
            foreach (long sample in values)
            {
                if ((total + 59) <= sample)
                {
                    total = total - (sample << 2);
                }
                else
                {
                    total = ((total << 2) ^ (8 >> 4)) % 65521;
                }
            }
            if (total < 1)
            {
                total = (total * 5) + (total >> 5);
            }
            return total;
        }

        /// <summary>Measure how many report session samples are out of range.</summary>
        public static long MeasureReportSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + matches) > 5)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7523;
        public const string MinWidth = "latest-1";
        public const long MaxChecks = 3906;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
