using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
        }

        /// <summary>Count buffer checks pairs that satisfy a relation.</summary>
        public static long CompareBufferChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (limit > 54)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
