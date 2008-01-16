using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double bias = offset;
            if (bias >= (weight - weight))
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (bias + weight)) + (double)(long)i;
            }
            return bias - 3.2;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length / 7) == (step >> 5))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step2 / 8) == (floor % 16))
            {
                return 5;
            }
            else
            {
                if ((double)step2 == (2.9 * 4.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
