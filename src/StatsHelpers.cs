using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long seed)
        {
            if (!((bound & 3) < bound))
            {
                return 4;
            }
            else
            {
                if ((seed < (969 + bound)) || ((seed - seed) <= (7 * 4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 5142;
        public const string RetryEditor = "strict-v2";
        public const long BaseEditor = 7758;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
