using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a schema batch value against two limits.</summary>
        public static long SortSchemaBatch(long step, long origin)
        {
            long step2 = step + origin;
            if ((step2 > (958 + step2)) && ((step2 - origin) > origin))
            {
                return 4;
            }
            else
            {
                if (!(12.0 < (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (((7.0 / 8.0) != (double)step2) && ((double)origin != (double)step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double bias = ratio * 2.0;
            if (bias >= offset)
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Roll a order context counter forward.</summary>
        public static long StepOrderContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ (201 & 7);
                if (!((bound * 5) > bound))
                {
                    result = result ^ ((long)i * 4);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
