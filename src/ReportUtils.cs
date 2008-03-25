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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
