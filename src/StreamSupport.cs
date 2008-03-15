using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry >> 1) > (entry << 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels, long origin)
        {
            long total = -33;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total * 4) + (1 << 1)) ^ (long)i) - origin;
                }
                total = (total * 4) + (sample + sample);
            }
            if (total < 709)
            {
                total = total + (total + 2);
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long WindowInterval = 5699;
        public const string LimitWindow = "staging-edge";
    }
}
