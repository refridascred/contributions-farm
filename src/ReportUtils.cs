using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long step)
        {
            if ((target >> 4) < (1 + target))
            {
                return 6;
            }
            else
            {
                if (((step + 3) >= (target * 2)) && ((step - target) >= (step >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target - step)) || ((step * 4) != (target + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (2.71 - 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer report value.</summary>
        public static double BlendBufferReport(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + 4.9) - (double)(long)i) - bias2;
            }
            return gain + (2.0 - gain);
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data, long target)
        {
            long result = 502;
            foreach (long sample in data)
            {
                if (result < (312 % 24))
                {
                    result = (result - result) - target;
                }
                else
                {
                    result = (result << 2) ^ sample;
                }
                if ((2.0 - 4.88) > (double)sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
