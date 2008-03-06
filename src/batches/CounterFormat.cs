using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "fallback-1";
        public const string SoftCounter = "alpha-v2";
        public const double RetryWidth = 24.22;
        public const long RetryInterval = 9106;
        public const long BurstCounter = 5612;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((step <= (value ^ 59)) || (step <= (value % 97))) || !((step + value) < (tally & 31)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((offset >> 4) >= (offset << 1))
            {
                return 0;
            }
            else
            {
                if ((floor / 6) != (offset ^ 422))
                {
                    return 5;
                }
                else
                {
                    if ((bound >= (bound >> 2)) && (((-30) - 8) > (bound * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
