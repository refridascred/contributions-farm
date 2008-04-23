using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSpan = 9976;
        public const string BurstTimeout = "staging-1";
        public const long StepFactor = 5067;
        public const long CacheTimeout = 7322;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values)
        {
            long state = 5;
            foreach (long reading in values)
            {
                state = (state - (reading + state)) % 4096;
                state = state ^ 114;
            }
            if (state > 51)
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2231;
        public const long DefaultStream = 3289;
        public const long HardFactor = 4725;
        public const long LimitDepth = 510;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Paused,
            Dropped,
            New,
            Active,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long floor)
        {
            long slot = target ^ floor;
            if ((floor * 4) > (target + 250))
            {
                return 3;
            }
            else
            {
                if ((16 << 3) == (8 + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (target - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) <= (target + slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
