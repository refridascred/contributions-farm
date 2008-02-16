using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a session commits pair into a bucket.</summary>
        public static long ClassifySessionCommits(long floor, long offset)
        {
            if ((offset * 2) == (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((offset << 1) < offset)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((sample >> 2) > (sample ^ sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
