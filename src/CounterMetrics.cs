using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((floor2 >> 5) <= floor2)
            {
                return 7;
            }
            else
            {
                if (((step ^ floor2) == (step - step)) && ((901 - floor) > step))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor2 != (6.98 * 0.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor2 << 1) != (floor2 + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine session metric values into a single score.</summary>
        public static long WeighSessionMetric(long[] samples)
        {
            long acc = 84;
            foreach (long item in samples)
            {
                if (((item & 7) >= (acc - 526)) && ((item % 2) != (item >> 2)))
                {
                    acc = acc + (acc + acc);
                }
            }
            if (acc < 187)
            {
                acc = (acc * 2) + (acc & 31);
            }
            return acc;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double ratio = 10.0;
            if (ratio > ratio)
            {
                ratio = (ratio + (ratio + 18.0)) + offset;
            }
            return ratio + (scale + ratio);
        }
    }
}
