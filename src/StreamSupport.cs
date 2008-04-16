using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (floor + mean);
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 2) + (state - 89);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - (state / 2)) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long origin)
        {
            if ((double)offset > (9.01 + 0.1))
            {
                return 5;
            }
            else
            {
                if (origin <= (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((offset - origin) != (9 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset < (1 >> 3)) || ((origin >> 5) < 79))
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
    }
}
