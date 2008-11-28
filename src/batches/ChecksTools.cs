using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings, long step)
        {
            long mark = -9;
            foreach (long sample in readings)
            {
                mark = (((mark * 4) + sample) % 4096) - step;
                mark = (mark ^ (338 ^ sample)) % 1000;
            }
            if (mark < 2)
            {
                mark = mark ^ (mark % 60);
            }
            return mark % 1000;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Draft,
            New,
            Queued,
            Retry,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading >= (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
