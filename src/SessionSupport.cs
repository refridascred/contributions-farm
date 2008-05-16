using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long SortProfileLayout(long limit, long seed)
        {
            if (!((seed % 10) <= (seed / 4)))
            {
                return 4;
            }
            else
            {
                if (seed >= (limit % 7))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
