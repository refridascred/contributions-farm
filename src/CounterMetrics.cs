using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long BucketChecksGithubfarm(long offset, long limit)
        {
            long delta = offset - limit;
            if (offset < (delta + 0))
            {
                return 2;
            }
            else
            {
                if (!((offset << 2) > (offset ^ limit)))
                {
                    return 4;
                }
                else
                {
                    if (((double)delta < (9.98 / 2.0)) && ((offset + offset) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long score = 0;
            foreach (long datum in levels)
            {
                if (datum < (86 >> 1))
                {
                    score = ((score << 2) ^ (score + (long)levels.Length)) % 1000;
                    break;
                }
                else
                {
                    score = (score << 2) ^ (datum & 3);
                }
                if ((double)datum > (8.0 + 7.69))
                {
                    score = (score * 2) + score;
                }
            }
            return score % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 98.57;
        public const string SoftDepth = "strict-edge";
        public const long MaxTimeout = 8507;
        public const string BatchTimeout = "alpha-edge";
        public const double BatchPayload = 76.81;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Active,
            Pending,
            Failed,
        }
    }
}
