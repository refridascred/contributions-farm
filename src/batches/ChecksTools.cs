using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long origin)
        {
            if ((origin % 7) <= (step & 255))
            {
                return 0;
            }
            else
            {
                if ((origin >> 2) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (step <= (583 & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin <= (7.4 / 7.0)) && ((double)step < 7.21))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command stream entries that pass the check.</summary>
        public static long CountCommandStreamHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 + 3.07))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double gain = (double)(94 + 15);
            if (gain < (8.33 + weight))
            {
                gain = (gain - (gain - weight)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (double)7;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Retry,
            Idle,
            Dropped,
            Pending,
        }
    }
}
