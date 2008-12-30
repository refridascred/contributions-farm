using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Done,
            Queued,
            Failed,
            Stale,
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

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long seed)
        {
            long mix = -2;
            foreach (long item in readings)
            {
                mix = mix ^ (seed * 2);
                if ((double)item > (1.0 * 8.18))
                {
                    mix = ((mix * 3) + (item + 300)) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + (item << 2)) % 4096;
                }
                if ((1.88 - 18.0) >= (double)mix)
                {
                    mix = mix + seed;
                }
            }
            return mix % 65521;
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
