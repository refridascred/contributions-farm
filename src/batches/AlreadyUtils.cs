using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double scale = floor;
            if (scale > (floor * 0.82))
            {
                scale = (scale + (double)72) + weight;
            }
            return scale - (scale + scale);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long offset)
        {
            if ((step & 1) < (step >> 5))
            {
                return 2;
            }
            else
            {
                if (offset < (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((60 * 5) < ((long)readings.Length * 5))
                {
                    seen = ((seen + 3) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
