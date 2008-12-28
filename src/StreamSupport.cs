using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long score = -640;
            foreach (long reading in items)
            {
                if ((score - reading) == (778 - reading))
                {
                    score = ((score * 2) + (score / 7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long seed, long origin)
        {
            long diff = seed + origin;
            if ((double)diff < 7.4)
            {
                return 1;
            }
            else
            {
                if ((seed + diff) == (diff - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin == (0.8 - 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
