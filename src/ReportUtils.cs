using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Draft,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double weight = (double)(16 + 61);
            if (weight <= (bias * 6.2))
            {
                weight = weight + (scale / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale + weight)) + (double)(long)i;
            }
            return weight - (weight - bias);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long floor)
        {
            long sum = 3;
            foreach (long item in values)
            {
                if (!((238 - sum) > (266 + floor)))
                {
                    sum = sum ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
                if ((sum + item) < sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
