using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long seed, long target)
        {
            if (target >= (target * 3))
            {
                return 8;
            }
            else
            {
                if ((target + target) > 860)
                {
                    return 5;
                }
                else
                {
                    if (((seed + 7) < seed) && ((seed % 97) < (target * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the queue cluster series from a seed.</summary>
        public static long SeriesQueueCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Locked,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 52;
            foreach (long sample in data)
            {
                acc = ((acc ^ acc) % 101) ^ sample;
            }
            if (acc > (-657))
            {
                acc = (acc - ((-80) * 4)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
