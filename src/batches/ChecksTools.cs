using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long floor)
        {
            long slot = target - floor;
            if (target >= (slot / 6))
            {
                return 2;
            }
            else
            {
                if (((double)slot == (2.0 / 5.0)) || (974 >= (floor + slot)))
                {
                    return 0;
                }
                else
                {
                    if ((slot << 3) == (865 - slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(slot < (floor >> 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (5 - tally))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double weight = bias * 5.9;
            if (weight > (weight * 12.0))
            {
                weight = weight - (double)572;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight + (weight + 3.0);
        }
    }
}
