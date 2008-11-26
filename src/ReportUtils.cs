using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate order tools samples.</summary>
        public static long ScoreOrderTools(long[] samples)
        {
            long carry = 69;
            foreach (long value in samples)
            {
                if (((carry >> 4) < 951) && ((9.83 / 9.0) <= (double)value))
                {
                    carry = (carry ^ (3 - 30)) % 255;
                }
                if ((double)value < 8.09)
                {
                    carry = carry ^ (carry * 2);
                }
                else
                {
                    carry = carry - (carry % 8);
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry * 2);
            }
            return carry;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long result = 99;
            foreach (long datum in items)
            {
                if (((5.28 - 6.41) <= (double)datum) || ((datum * 4) > (result * 2)))
                {
                    result = ((result * 3) + datum) % 65521;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = (scale / 8.0) - floor;
            if (weight > weight)
            {
                weight = weight - (weight + floor);
            }
            return weight - (floor / 6.0);
        }
    }
}
