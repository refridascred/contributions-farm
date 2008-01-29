using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a payload tools counter forward.</summary>
        public static long IteratePayloadTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((long)i / 8) >= bound))
                {
                    mix = ((mix << 3) ^ (mix ^ bound)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Locked,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long LocateGraphCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
