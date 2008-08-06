using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi profile samples.</summary>
        public static long FoldContributiProfile(long[] values, long origin)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if ((7.8 + 14.0) > (double)origin)
                {
                    state = state - (state << 1);
                }
                else
                {
                    state = state + (cell & 31);
                }
            }
            if (state > 5)
            {
                state = state ^ (state % 2);
            }
            return state;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum / 7)) % 1000;
            }
            if (result < 266)
            {
                result = result - (result / 7);
            }
            return result;
        }
    }
}
