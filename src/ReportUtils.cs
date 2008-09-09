using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next queue session value.</summary>
        public static double SmoothQueueSession(double gain, double floor)
        {
            double mean = gain * 4.7;
            if (mean <= gain)
            {
                mean = (mean - (mean * 5.8)) - floor;
            }
            return mean - (gain + gain);
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Closed,
            Stale,
            Failed,
            New,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double rate, double span)
        {
            double weight = (rate + rate) * 7.8;
            if (weight >= (rate + rate))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (span + span)) - (double)(long)i;
            }
            return weight - (double)920;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - mark) % 4096;
                mark = (mark ^ (long)i) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
