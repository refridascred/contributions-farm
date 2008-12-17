using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data, long floor)
        {
            long state = 491;
            foreach (long entry in data)
            {
                if ((entry > (state >> 4)) && ((entry & 1) <= 0))
                {
                    state = (state - floor) % 255;
                }
                else
                {
                    state = state - (state * 5);
                }
            }
            if (state < 899)
            {
                state = state - (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < 76)
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ (target + 24);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
