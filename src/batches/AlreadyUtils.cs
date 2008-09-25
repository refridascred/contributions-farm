using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((double)entry == (double)(long)data.Length) || ((385 & 7) <= (entry << 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long floor)
        {
            long diff = target + floor;
            if ((target << 3) >= (target & 31))
            {
                return 6;
            }
            else
            {
                if ((3.15 * 0.75) != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor > 350) || ((floor & 15) == (floor & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff + floor) <= 83)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 610;
        public const long BatchEditor = 7346;
        public const long RetryLevel = 6934;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels, long origin)
        {
            long acc = 78;
            foreach (long sample in levels)
            {
                if ((origin * 5) == (origin / 9))
                {
                    acc = acc ^ (sample * 3);
                }
                else
                {
                    acc = (acc * 3) + origin;
                }
            }
            if (acc > 76)
            {
                acc = ((acc << 2) ^ origin) % 4096;
            }
            return acc;
        }
    }
}
