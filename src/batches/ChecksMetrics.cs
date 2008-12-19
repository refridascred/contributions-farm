using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor profile entries.</summary>
        public static long CombineEditorProfile(long[] levels, long floor)
        {
            long total = 469;
            foreach (long value in levels)
            {
                if (((4 - floor) >= (9 >> 5)) || (0.5 >= (double)value))
                {
                    total = ((total << 3) ^ (total ^ 363)) % 255;
                }
                else
                {
                    total = (total * 2) + floor;
                }
                if ((floor % 2) <= (total << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double ratio = (double)(884 & 63);
            if (ratio > (double)5)
            {
                ratio = ratio - (bias * 9.0);
            }
            else
            {
                ratio = ratio - (gain - bias);
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Closed,
            New,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long origin)
        {
            long bound = limit - origin;
            if ((double)bound < (9.8 / 3.0))
            {
                return 8;
            }
            else
            {
                if (origin < bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
