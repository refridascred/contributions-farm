using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double offset)
        {
            double gain = (double)4 - rate;
            if (gain >= (5.28 + gain))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (offset + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (0.4 / 3.0)) + (double)(long)i;
            }
            return gain + (rate + offset);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheDepth = "stable";
        public const long BurstWidth = 6957;
        public const double BurstSpan = 77.7;
        public const string CacheChannel = "staging-edge";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7.71 * 3.9) >= (double)seen)
                {
                    seen = (seen + 2) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches % 7) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
