using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long origin, long floor)
        {
            long span = origin ^ floor;
            if (!((floor >> 5) <= span))
            {
                return 3;
            }
            else
            {
                if (((span - floor) > 87) && ((origin / 4) <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >= (floor >> 4)) || ((15.0 * 9.0) <= (double)span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
