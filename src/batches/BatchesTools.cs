using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema stream samples are out of range.</summary>
        public static long TallySchemaStreamMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value > (value % 2))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 4709;
        public const long CacheRatio = 6209;
        public const long SoftSize = 7569;
        public const string HardCount = "standard-1";
        public const string WindowRatio = "strict-edge";
    }
}
