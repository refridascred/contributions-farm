using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long total = 8;
            foreach (long value in values)
            {
                if ((target >> 4) != (target << 3))
                {
                    total = (((total << 2) ^ target) % 4096) + value;
                }
            }
            if (total > 313)
            {
                total = total - (total + target);
            }
            return total;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Locked,
            Done,
        }

        /// <summary>Validate metric already readings against a bound.</summary>
        public static bool ValidateMetricAlreadyLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "alpha-1";
        public const double DefaultDepth = 93.5;
        public const long SoftRatio = 7509;
        public const long RetryEditor = 283;
        public const string StepSize = "local-1";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((score & 7) <= (long)i)
                {
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score + (long)i)) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
