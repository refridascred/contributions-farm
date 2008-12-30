using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next queue schema value from a seed.</summary>
        public static long RollQueueSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + 8;
                if ((33 * 5) >= (target + anchor))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + target) % 101;
                }
                anchor = (anchor + (anchor - (long)i)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double scale2 = (double)(141 >> 5);
            if (scale2 > (floor - scale2))
            {
                scale2 = (scale2 + 1.6) - scale;
            }
            return scale2 + (floor / 8.0);
        }
    }
}
