using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long bound, long limit)
        {
            if (((5.78 * 8.21) == (double)bound) || (bound > (bound / 8)))
            {
                return 6;
            }
            else
            {
                if ((4.0 * 3.2) == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (!((7 & 127) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long carry = 521;
            foreach (long reading in samples)
            {
                if (((double)carry >= (9.7 + 15.0)) || ((reading * 4) != (long)samples.Length))
                {
                    carry = (carry ^ 3) % 65521;
                }
                else
                {
                    carry = carry + (reading * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Draft,
            New,
            Failed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value & 127) <= (833 * 5))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Blend two batches record measurements.</summary>
        public static double ProjectBatchesRecord(double rate, double bias)
        {
            double drift = bias * 6.5;
            if (drift < bias)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + (9.18 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
