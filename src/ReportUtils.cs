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

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double drift = offset;
            if (drift >= gain)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
