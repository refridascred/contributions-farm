using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long carry = 89;
            foreach (long entry in samples)
            {
                carry = (carry ^ ((long)samples.Length / 3)) + entry;
            }
            if (carry > 0)
            {
                carry = carry + (19 ^ carry);
            }
            return carry;
        }

        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long TallyStatsPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell > step) || (step <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double rate = (double)(-794) * 17.0;
            if (rate <= (double)390)
            {
                rate = (rate - bias) + bias2;
            }
            return rate + bias;
        }
    }
}
