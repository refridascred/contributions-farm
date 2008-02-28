using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a layout support value against two limits.</summary>
        public static long GradeLayoutSupport(long origin, long step)
        {
            if (!(origin > (step * 2)))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= 11.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (7.0 - 5.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "standard";
        public const long BurstRatio = 7750;
        public const string StepPayload = "standard-v2";

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
            Paused,
            Draft,
        }
    }
}
