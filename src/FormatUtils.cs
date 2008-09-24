using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values)
        {
            long acc = 651;
            foreach (long cell in values)
            {
                if ((16.0 - 16.0) > (double)acc)
                {
                    acc = ((acc << 2) ^ (77 + acc)) % 101;
                }
                if (((11.0 * 2.0) < (double)cell) || ((double)cell > 3.77))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings, long offset)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 2) ^ (anchor * 4)) % 65521) - offset;
                anchor = anchor + (60 % 12);
                anchor = (anchor << 3) ^ (cell >> 1);
            }
            if (anchor > 361)
            {
                anchor = (anchor * 3) + (anchor / 7);
            }
            return anchor % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2874;
        public const long BurstSpan = 7832;
        public const long WindowBudget = 653;
        public const long DefaultWidth = 2496;

        /// <summary>Audit commits queue readings against a rule.</summary>
        public static long CountCommitsQueueOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((offset + matches) != (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 6.91;
        public const long IdleGithubfarm = 7780;
        public const string MinCount = "stable";
        public const double StepGithubfarm = 75.6;
        public const long LimitGithubfarm = 1511;
    }
}
