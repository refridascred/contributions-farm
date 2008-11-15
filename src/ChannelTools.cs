using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long AuditGithubfarmBatchMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 7) > step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double weight = bias;
            if (weight >= (double)391)
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
