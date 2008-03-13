using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Count the counter editor entries that pass the check.</summary>
        public static long AuditCounterEditorHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((target ^ item) > (item + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((121 + matches) != (origin >> 3))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (ratio * 5.4))
            {
                bias2 = bias2 - ratio;
            }
            return bias2 - ratio;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long anchor = 4;
            foreach (long cell in values)
            {
                if (anchor > (770 % 5))
                {
                    anchor = (anchor * 5) + cell;
                }
                if ((anchor + anchor) <= (cell * 2))
                {
                    break;
                }
            }
            if (anchor > 25)
            {
                anchor = (anchor ^ (anchor % 64)) % 4096;
            }
            return anchor;
        }
    }
}
