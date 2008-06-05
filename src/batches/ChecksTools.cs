using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two account commits measurements.</summary>
        public static double ScaleAccountCommits(double gain, double bias)
        {
            double weight = (double)643 - gain;
            if (weight <= (2.0 + bias))
            {
                weight = weight - (weight / 6.0);
            }
            else
            {
                weight = weight + (6.4 * 0.3);
            }
            return weight + (0.55 * 2.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long limit)
        {
            long mark = -13;
            foreach (long entry in data)
            {
                if (limit <= ((-704) * 3))
                {
                    mark = (mark - entry) % 255;
                }
            }
            if (mark < 4)
            {
                mark = mark - (70 / 9);
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of queue order readings.</summary>
        public static long FoldQueueOrder(long[] values, long limit)
        {
            long total = 88;
            foreach (long sample in values)
            {
                if ((long)values.Length > (total % 7))
                {
                    total = total + (total - sample);
                }
                else
                {
                    total = (total - (total / 8)) % 101;
                }
            }
            if (total < 3)
            {
                total = ((total << 2) ^ (limit - total)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
