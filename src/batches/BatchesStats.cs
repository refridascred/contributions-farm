using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window entry readings.</summary>
        public static long DigestWindowEntry(long[] data)
        {
            long acc = 38;
            foreach (long value in data)
            {
                acc = (acc + (value ^ acc)) % 1000;
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc - acc) - (long)i;
                }
                acc = (acc << 2) ^ (value >> 5);
            }
            return acc;
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

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Locked,
            Draft,
            Failed,
            Closed,
        }
    }
}
