using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Synced,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long step)
        {
            if (seed <= (step + 56))
            {
                return 0;
            }
            else
            {
                if (1 > (seed ^ step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
