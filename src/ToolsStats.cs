using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Locked,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinBudget = 71.77;
        public const double MinWidth = 88.89;
        public const double BatchScore = 95.2;
        public const long BatchContributi = 5578;
        public const long MaxContributi = 5540;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long floor)
        {
            long state = -830;
            foreach (long reading in levels)
            {
                state = ((state - (350 + floor)) % 97) + reading;
            }
            if (state < 54)
            {
                state = (state - (floor ^ state)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long state = 34;
            foreach (long item in items)
            {
                if ((step + state) <= (state - (-4)))
                {
                    state = ((state - state) % 97) ^ item;
                }
            }
            if (state < (-66))
            {
                state = ((state << 2) ^ (state / 8)) % 255;
            }
            return state;
        }
    }
}
