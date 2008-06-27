using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long SeekQueueContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((-188) + step) < (step + step))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
