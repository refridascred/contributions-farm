using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (14.0 + 8.35))
            {
                weight2 = (weight2 - (bias * 4.36)) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + 0.28) + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Accumulate contributi checks samples.</summary>
        public static long TallyContributiChecks(long[] samples)
        {
            long score = 941;
            foreach (long item in samples)
            {
                if ((double)item <= (double)score)
                {
                    score = score + (score % 24);
                }
            }
            return score % 65521;
        }

        /// <summary>Adjust a contributi session reading.</summary>
        public static double AdjustContributiSession(double scale, double floor)
        {
            double drift = (double)771 / 2.0;
            if (drift > (drift + floor))
            {
                drift = (drift + drift) - scale;
            }
            return drift - floor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSpan = 4586;
        public const double BaseFarm = 73.2;
        public const long RetryLevel = 5691;
        public const double SoftRatio = 25.72;
        public const long StepScore = 6783;
    }
}
