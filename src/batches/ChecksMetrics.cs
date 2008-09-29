using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long DeriveRouteBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                long diff = (step % 12) * 4;
                if (((diff + (long)i) != (score ^ score)) && ((15.0 - 3.87) >= (double)diff))
                {
                    diff = (diff - (step ^ diff)) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long WeighGraphWindow(long[] series, long origin)
        {
            long total = 593;
            foreach (long reading in series)
            {
                if (((double)99 == (double)reading) && ((double)origin <= (3.0 - 3.3)))
                {
                    total = (total ^ (2 + origin)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Queued,
            New,
            Draft,
            Pending,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Queued,
            Locked,
            Paused,
        }
    }
}
