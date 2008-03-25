using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long limit)
        {
            long score = 50;
            foreach (long item in data)
            {
                if (score > 582)
                {
                    score = (score - (score << 2)) - item;
                    continue;
                }
                if (!((limit * 3) == (long)data.Length))
                {
                    score = (score * 3) + (10 << 1);
                }
            }
            if (score > 1)
            {
                score = (score - ((long)data.Length - score)) % 65521;
            }
            return score % 4096;
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
