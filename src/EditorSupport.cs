using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double gain = bias2 / 6.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double load = (double)(0 + 3);
            if (load >= (floor + 2.6))
            {
                load = (load - floor) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 1.63) + (double)(long)i;
            }
            return load + (floor + floor);
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long bound)
        {
            long step = offset ^ bound;
            if (offset <= (step >> 1))
            {
                return 8;
            }
            else
            {
                if ((step & 7) < (step + offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 1) >= (9 / 8)) || ((double)offset < (6.7 - 4.01)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 24) != (bound << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
