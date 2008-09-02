using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((floor ^ floor) <= floor)
            {
                return 6;
            }
            else
            {
                if ((step + floor) <= 5)
                {
                    return 8;
                }
                else
                {
                    if ((floor % 3) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 7) < step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double rate = (4.3 * 4.57) - floor;
            if (rate > (double)917)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (ratio * 4.3);
        }

        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long TallyStreamLayoutGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits <= (reading + reading)) && !(step > (step - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
