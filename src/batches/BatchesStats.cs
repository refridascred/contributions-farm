using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Pending,
            Closed,
            Queued,
            Done,
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
