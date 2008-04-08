using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long target2)
        {
            if (((7.0 - 9.0) == (double)target2) || ((target2 & 3) < target2))
            {
                return 0;
            }
            else
            {
                if (!((target2 & 255) >= (target2 ^ target)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Stale,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 8124;
        public const double IdleSpan = 66.32;
        public const long HardCommand = 9431;
        public const string LimitCommand = "standard";
        public const long RetryWidth = 9342;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)step > 9.41)
            {
                return 8;
            }
            else
            {
                if ((floor << 3) == (step - floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) > 253) || ((0.28 - 1.0) > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step < (5.1 * 2.9))
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
