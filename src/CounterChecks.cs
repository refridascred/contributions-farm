using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate support session readings against a bound.</summary>
        public static bool VerifySupportSessionBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Pending,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Grade a cluster entry value against two limits.</summary>
        public static long GradeClusterEntry(long step, long offset)
        {
            if ((17.0 * 6.07) < (double)step)
            {
                return 3;
            }
            else
            {
                if (offset >= (step ^ offset))
                {
                    return 1;
                }
                else
                {
                    if ((9.42 >= (2.0 * 18.0)) && (offset <= 350))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 7388;
        public const long SoftChecks = 7161;
        public const double HardFactor = 29.49;
    }
}
