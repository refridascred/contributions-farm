using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (15.0 * 5.1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total + 887;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
