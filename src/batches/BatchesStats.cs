using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            long lane = origin + offset;
            if ((origin - origin) <= (4 * 3))
            {
                return 7;
            }
            else
            {
                if (((offset % 8) == (lane ^ origin)) || ((lane - lane) == (83 / 2)))
                {
                    return 4;
                }
                else
                {
                    if (lane < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            New,
            Queued,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                long next = (bound - bound) + (score >> 1);
                score = score + (42 + score);
                if (!(((long)i - score) >= ((long)i ^ next)))
                {
                    score = score + bound;
                    next = ((next << 3) ^ (bound ^ next)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
