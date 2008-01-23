using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i % 64) > (offset << 3)) && ((offset / 9) >= offset))
                {
                    mix = mix - (offset ^ offset);
                    mix = (mix * 5) + offset;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((floor >> 1) < (entry / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Draft,
            Closed,
        }
    }
}
