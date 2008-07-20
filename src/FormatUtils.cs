using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)4 >= (2.77 * 16.0)) && (84 <= (limit % 12)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Dropped,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((entry << 3) >= (entry >> 5)) || ((1.2 * 2.0) < (double)entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 49.04;
        public const long CacheGithubfarm = 2124;
        public const long DefaultGithubfarm = 256;
        public const string StepGithubfarm = "open-1";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
