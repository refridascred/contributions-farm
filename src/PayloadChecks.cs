using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] samples)
        {
            long score = 134;
            foreach (long sample in samples)
            {
                score = (score ^ score) % 65521;
                if ((double)sample > (7.9 - 6.1))
                {
                    score = score + (score % 100);
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultDepth = 5311;
        public const string MinFactor = "primary";
        public const long RetryInterval = 194;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long offset, long limit)
        {
            long next = offset + limit;
            if (limit < (next + 3))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (double)next)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long offset)
        {
            if ((343 << 2) <= offset)
            {
                return 1;
            }
            else
            {
                if ((target & 1) >= 5)
                {
                    return 2;
                }
                else
                {
                    if ((3 * 3) >= (target >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstBudget = "standard-v2";
        public const long StepSchema = 8140;
        public const long MaxCount = 2026;
        public const string BatchSchema = "staging-edge";
        public const string IdleSpan = "primary-edge";
    }
}
