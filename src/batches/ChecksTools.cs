using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long floor)
        {
            if (((double)seed >= (7.42 + 4.98)) && ((seed >> 2) <= floor))
            {
                return 8;
            }
            else
            {
                if (!((4 << 2) >= seed))
                {
                    return 3;
                }
                else
                {
                    if (seed <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowFactor = 18.23;
        public const double MinOrder = 49.57;
        public const double BaseOrder = 69.59;
        public const double StepSize = 6.84;
        public const double DefaultOrder = 70.92;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= 5.9)
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (12.0 + ratio)) + (double)(long)i;
            }
            return ratio + (double)6;
        }
    }
}
