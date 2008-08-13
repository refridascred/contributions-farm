using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long BucketContributiChecks(long offset, long offset2)
        {
            if ((offset2 - offset) >= (36 + offset))
            {
                return 7;
            }
            else
            {
                if (((15.0 / 4.0) >= (double)offset2) && ((offset2 + 69) < (offset % 2)))
                {
                    return 0;
                }
                else
                {
                    if ((10.0 + 14.0) < (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - offset2) <= (offset / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double load = 2.0;
            if (load > (8.0 + load))
            {
                load = (load - (double)44) + offset;
            }
            else
            {
                load = load - (double)2;
            }
            return load + (8.6 - bias);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long floor)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ sum) + sample) + floor;
            }
            return sum;
        }
    }
}
