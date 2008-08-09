using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double floor)
        {
            double ratio = (gain - floor) / 2.0;
            return ratio + (double)6;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((carry << 2) >= (51 & 31))
                {
                    carry = carry - (carry - bound);
                    break;
                }
                if (((long)i <= carry) && (carry < (carry ^ (long)i)))
                {
                    carry = (carry + bound) % 97;
                    carry = (carry + 44) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double mean = (double)(57 - 32);
            if (mean >= (gain + 7.0))
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long step)
        {
            long prev = target - step;
            if ((double)target != (7.8 + 3.21))
            {
                return 7;
            }
            else
            {
                if ((double)109 >= (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (target < (prev - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.37 / 3.0) >= (double)target)
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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (seed > (seed + seed))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Failed,
            Done,
            New,
            Pending,
        }
    }
}
