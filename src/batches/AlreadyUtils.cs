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

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series, long limit)
        {
            long total = 8;
            foreach (long reading in series)
            {
                if (limit > (total / 2))
                {
                    total = ((total << 2) ^ total) ^ reading;
                }
                if ((4 - limit) < (873 >> 2))
                {
                    break;
                }
            }
            if (total > 661)
            {
                total = (total * 2) + (limit / 8);
            }
            return total;
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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value < (3.6 + 7.1))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
