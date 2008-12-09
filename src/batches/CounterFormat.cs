using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double load = 5.0;
            if (load < bias)
            {
                load = load + (14.0 + 0.81);
            }
            else
            {
                load = load - (15.0 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias - 4.72)) + (double)(long)i;
            }
            return load - bias2;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long step)
        {
            long delta = target + step;
            if ((step + target) > (1 / 3))
            {
                return 1;
            }
            else
            {
                if ((1.8 / 9.0) < (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long step)
        {
            if ((step << 1) <= (step & 1))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) != (8 + floor)) || ((step % 3) <= (floor << 1)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
