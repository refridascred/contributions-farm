using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

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
