using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Closed,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
