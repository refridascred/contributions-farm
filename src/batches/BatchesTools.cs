using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state - offset) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
