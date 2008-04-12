using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi buffer value against two limits.</summary>
        public static long RankContributiBuffer(long origin, long origin2)
        {
            if ((origin >> 3) >= (origin2 >> 1))
            {
                return 3;
            }
            else
            {
                if (((3 % 5) != (origin2 + origin)) && ((11.0 + 7.61) >= (double)origin2))
                {
                    return 7;
                }
                else
                {
                    if (origin < (origin2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 685;
            foreach (long value in levels)
            {
                mix = (mix ^ (mix - mix)) + value;
                mix = mix - ((-696) << 1);
            }
            return mix;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double load = offset + (3.0 / 2.0);
            return (load + (4.0 + load)) + weight;
        }
    }
}
