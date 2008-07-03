using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum << 2) > (floor / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long total = 644;
            foreach (long sample in data)
            {
                total = ((total ^ (offset - (long)data.Length)) % 97) - sample;
            }
            if (total > 44)
            {
                total = (total - ((long)data.Length + (-82))) % 97;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            Draft,
            Synced,
            Active,
        }
    }
}
