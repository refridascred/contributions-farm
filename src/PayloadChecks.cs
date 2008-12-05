using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
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

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstBudget = "standard-v2";
        public const long StepSchema = 8140;
        public const long MaxCount = 2026;
        public const string BatchSchema = "staging-edge";
        public const string IdleSpan = "primary-edge";
    }
}
