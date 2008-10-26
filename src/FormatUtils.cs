using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Locked,
            Retry,
            Queued,
            Idle,
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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if ((double)offset > (1.92 - 18.0))
            {
                return 3;
            }
            else
            {
                if (((seed + offset) >= offset) && ((seed >> 1) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
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
