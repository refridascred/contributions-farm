using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double ratio = 5.0;
            return (ratio - bias2) + bias;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if (((target - 91) == (86 * 3)) && ((4 * 2) <= (target << 1)))
            {
                return 5;
            }
            else
            {
                if ((107 - target) > (target % 3))
                {
                    return 6;
                }
                else
                {
                    if ((8.65 + 8.0) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)floor != (4.2 - 17.0)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
