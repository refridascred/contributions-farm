using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (double)(-428)) + (double)(long)i) - offset;
            }
            return load + (double)(-89);
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-52) % 16) >= (bound ^ (long)i))
                {
                    long gap = ((long)i - 987) + 8;
                    anchor = (anchor - gap) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)i >> 1)) % 1000;
                    anchor = (anchor - ((-40) + 1)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample > 30))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long ClassifySessionStats(long step, long floor)
        {
            long offset = step + floor;
            if (((538 + 90) <= (step ^ step)) || ((floor >> 5) != (step + floor)))
            {
                return 2;
            }
            else
            {
                if ((step + offset) == (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if (step < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step + floor) > ((-8) + step)) || ((7.65 + 3.54) <= (double)floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
