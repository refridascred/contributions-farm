using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Measure how many support contributi samples are out of range.</summary>
        public static long CountSupportContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((691 << 1) == (seen >> 5)) || (sample < (-29)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ (limit << 1)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
