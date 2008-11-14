using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of context buffer readings.</summary>
        public static long CompareContextBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long bound)
        {
            if ((bound - bound) >= (bound % 16))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) < (target - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long origin)
        {
            long mix = 158;
            foreach (long reading in readings)
            {
                if (reading < (reading >> 4))
                {
                    mix = ((mix * 4) + (origin + origin)) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
