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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5131;
        public const long DefaultQueue = 4877;
        public const long CacheScore = 1292;
    }
}
