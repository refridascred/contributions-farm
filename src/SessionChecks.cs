using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cache already value from a seed.</summary>
        public static long RollCacheAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Locked,
            Queued,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels)
        {
            long acc = -3;
            foreach (long value in levels)
            {
                acc = (acc + (value << 1)) % 97;
                acc = (acc + (value - acc)) % 4096;
            }
            if (acc < 25)
            {
                acc = (acc << 2) ^ (acc * 3);
            }
            return acc;
        }
    }
}
