using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Queued,
            Ready,
            New,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            New,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "legacy";
        public const long DefaultSpan = 6789;
        public const long MinBudget = 1670;
        public const long IdleBudget = 1936;
        public const long BatchQueue = 6263;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
