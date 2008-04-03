using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a cluster format counter forward.</summary>
        public static long StepClusterFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state << 2) ^ state) + (long)i2;
                }
                state = ((state << 2) ^ step) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 19;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length < (7.3 * 6.48))
                {
                    score = ((score << 3) ^ (reading / 2)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a cache token pair into a bucket.</summary>
        public static long BucketCacheToken(long limit, long offset)
        {
            if ((double)limit > 8.3)
            {
                return 4;
            }
            else
            {
                if (((180 ^ limit) == (offset >> 1)) || ((limit * 3) != (limit + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > (1.1 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= 20.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Pending,
            Paused,
            Stale,
        }
    }
}
