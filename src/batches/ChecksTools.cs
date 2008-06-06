using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long seed)
        {
            long diff = bound + seed;
            if (bound <= (5 - diff))
            {
                return 8;
            }
            else
            {
                if (bound <= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long WeighWindowCommits(long[] data, long seed)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = (mix ^ (seed + 812)) + entry;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                total = ((total - total) % 255) ^ sample;
            }
            return total % 65521;
        }
    }
}
