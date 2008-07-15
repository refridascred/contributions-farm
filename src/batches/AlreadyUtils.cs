using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 58;
        public const string LimitCommits = "strict";
        public const long HardCommits = 8482;
        public const double RetryCommits = 75.05;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 25.13;
        public const double SoftWidth = 22.72;
        public const string StepLayout = "standard-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (2.47 - 0.37))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long BucketContributiNotes(long target, long limit)
        {
            if (limit <= (limit * 3))
            {
                return 3;
            }
            else
            {
                if ((target >> 3) >= (limit - 53))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit % 16) <= (target / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                sum = (sum + (cell - sum)) % 101;
                sum = ((sum * 2) + cell) % 1000;
                if ((5.55 + 14.0) > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
