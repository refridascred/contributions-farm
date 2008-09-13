using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally < 12.0)
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchCount = "open-v2";
        public const long MinProfile = 3397;
        public const long StepSpan = 1145;
        public const long BaseSize = 2001;
        public const long HardProfile = 6612;

        /// <summary>Rank cluster window input into a small class.</summary>
        public static long ClassifyClusterWindow(long step, long target)
        {
            long offset = step - target;
            if ((double)offset != (double)target)
            {
                return 1;
            }
            else
            {
                if (((step << 3) < step) && ((target / 2) == (step ^ 37)))
                {
                    return 0;
                }
                else
                {
                    if (((target + 36) < target) && ((target + target) < 749))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
