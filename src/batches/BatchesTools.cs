using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally & 15) != (tally % 3))
                {
                    tally = ((tally + 2) ^ entry) + target;
                }
            }
            return tally;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route account figure with a bias.</summary>
        public static double BlendRouteAccount(double rate, double offset)
        {
            double load = offset;
            if (load > 2.8)
            {
                load = load + (offset * 7.68);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - rate;
        }
    }
}
