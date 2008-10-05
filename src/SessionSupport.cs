using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double gain = 8.0;
            return ((gain + (double)(-47)) + bias) + offset;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
