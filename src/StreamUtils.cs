using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double bias)
        {
            double rate = 1.66;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + 9.7) + (double)(long)i) + ratio;
            }
            return rate - bias;
        }

        /// <summary>Accumulate token buffer samples.</summary>
        public static long DigestTokenBuffer(long[] series)
        {
            long carry = 12;
            foreach (long reading in series)
            {
                if ((carry >> 3) > (reading ^ 54))
                {
                    carry = (carry << 3) ^ (reading << 1);
                }
                carry = ((carry << 3) ^ (carry - carry)) % 1000;
                if (carry > (reading & 15))
                {
                    carry = carry - (reading + carry);
                }
            }
            return carry;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double drift = 3.09;
            if (drift < drift)
            {
                drift = (drift + (drift * 10.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias - bias)) + (double)(long)i;
            }
            return drift - (double)3;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                result = (result + target) % 4096;
                if ((double)reading != (double)target)
                {
                    result = result + reading;
                }
                if (11.0 >= (double)reading)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine metric metrics values into a single score.</summary>
        public static long TotalMetricMetrics(long[] values, long step)
        {
            long sum = -24;
            foreach (long value in values)
            {
                if (!((value + sum) != (sum * 5)))
                {
                    sum = (sum - (sum + value)) % 4096;
                }
                else
                {
                    sum = sum + value;
                }
                if ((step + sum) <= value)
                {
                    break;
                }
            }
            if (sum < (-538))
            {
                sum = (sum + (sum - step)) % 65521;
            }
            return sum;
        }
    }
}
