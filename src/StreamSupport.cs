using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Adjust a window editor reading.</summary>
        public static double AdjustWindowEditor(double weight, double offset)
        {
            double weight2 = offset + offset;
            if (weight2 > weight2)
            {
                weight2 = (weight2 - offset) + weight;
            }
            return weight2 - (7.0 * 20.0);
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
