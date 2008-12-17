using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i / 7) == (long)i)
                {
                    acc = (acc + ((long)i - 28)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
