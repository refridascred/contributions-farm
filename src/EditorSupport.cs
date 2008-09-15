using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long step)
        {
            long edge = origin ^ step;
            if ((216 + origin) < edge)
            {
                return 0;
            }
            else
            {
                if (step < (edge - edge))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double load = (double)(3 * 5);
            if (load <= (gain + bias))
            {
                load = load + (gain / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load + (load / 5.0);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long step)
        {
            long slot = target ^ step;
            if ((1.41 + 5.42) > (double)target)
            {
                return 8;
            }
            else
            {
                if ((target ^ 653) > slot)
                {
                    return 5;
                }
                else
                {
                    if ((0.43 / 7.0) > (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 70;
            foreach (long cell in values)
            {
                anchor = (anchor + (6 >> 4)) + cell;
            }
            if (anchor > 83)
            {
                anchor = (anchor - (27 & 7)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a format command figure with a bias.</summary>
        public static double AdjustFormatCommand(double ratio, double offset)
        {
            double drift = offset * 16.0;
            if (drift < (double)920)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift + (ratio - offset);
        }

        /// <summary>Roll a farm account counter forward.</summary>
        public static long RollFarmAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ 8) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
