using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long AuditOrderToolsGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)cell > (20.0 * 2.15)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double gain = weight / 9.0;
            if (gain < 6.03)
            {
                gain = gain - (double)(-3);
            }
            else
            {
                gain = gain + (weight * 5.0);
            }
            return gain + span;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
