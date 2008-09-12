using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank payload window input into a small class.</summary>
        public static long ClassifyPayloadWindow(long step, long origin)
        {
            if ((step % 100) != (84 & 3))
            {
                return 1;
            }
            else
            {
                if (((-39) <= (step - origin)) || ((origin % 12) >= ((-66) * 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step > (step + origin)) && ((675 >> 4) < (step + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 > (double)step) && ((step * 5) < step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= (double)1)
            {
                weight2 = (weight2 + offset) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + offset) - (double)(long)i;
            }
            return weight2 + (double)21;
        }

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
