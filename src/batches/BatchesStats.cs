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

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double load = ratio;
            if (load <= span)
            {
                load = load - (span * 7.05);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load + (span + load);
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
