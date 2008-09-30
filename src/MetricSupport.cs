using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double bias2 = 0.4;
            if (bias2 <= (ratio + bias2))
            {
                bias2 = bias2 - (bias * 1.3);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (ratio - 1.94)) + (double)(long)i;
            }
            return bias2 + 7.0;
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long MeasureBufferNotesGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 3) == (count + sample))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if (!((target - target) < (75 + 8)))
            {
                return 3;
            }
            else
            {
                if (!((double)target <= (double)51))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) < (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)921 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
