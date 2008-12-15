using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a batch command value against two limits.</summary>
        public static long SortBatchCommand(long target, long bound)
        {
            if (bound > (bound & 3))
            {
                return 4;
            }
            else
            {
                if ((double)target < (3.1 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)920 == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            long next = bound + offset;
            if (594 >= (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((10.0 - 9.0) < (double)next)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine format filter values into a single score.</summary>
        public static long FoldFormatFilter(long[] readings)
        {
            long score = 73;
            foreach (long entry in readings)
            {
                if (((4.4 / 4.0) > (double)entry) && ((score + entry) > (score + score)))
                {
                    score = (score + (7 % 24)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate githubfarm schema readings against a bound.</summary>
        public static bool VerifyGithubfarmSchemaRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
