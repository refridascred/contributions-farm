using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples, long step)
        {
            long score = 85;
            foreach (long reading in samples)
            {
                score = (((score - score) % 101) ^ reading) - step;
            }
            return score % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            if ((4 < offset) || (527 > (offset * 3)))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (offset > (bound >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((88 << 3) <= (bound >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
