using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double weight, double offset)
        {
            double weight2 = offset - (double)58;
            if (weight2 > (double)7)
            {
                weight2 = (weight2 - (weight2 * 8.4)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (offset - weight2);
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Closed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Retry,
            Closed,
        }
    }
}
