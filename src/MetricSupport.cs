using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double scale = (double)(18 >> 3);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (double)6) + (double)(long)i) + gain) + floor;
            }
            return scale - scale;
        }

        /// <summary>Classify a commits format pair into a bucket.</summary>
        public static long SortCommitsFormat(long target, long step)
        {
            long edge = target - step;
            if ((2.0 + 0.07) <= (double)step)
            {
                return 8;
            }
            else
            {
                if ((edge * 2) != (target * 3))
                {
                    return 6;
                }
                else
                {
                    if (step > (step / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 2) + (27 + state)) % 255) ^ (long)i2;
                }
                state = state - (2 / 7);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
