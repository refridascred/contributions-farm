using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long step)
        {
            long delta = seed - step;
            if ((double)step < 1.6)
            {
                return 2;
            }
            else
            {
                if (((delta - step) >= (step >> 1)) || ((delta * 2) != (step + 4)))
                {
                    return 1;
                }
                else
                {
                    if ((5.14 / 3.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta * 2) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetrySize = "staging";
        public const string SoftAccount = "alpha";
        public const long MaxSpan = 263;
        public const string MaxScore = "local-1";
        public const long StepAccount = 2937;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Synced,
            Pending,
        }
    }
}
