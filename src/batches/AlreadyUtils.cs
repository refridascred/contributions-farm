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

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long state = 591;
            foreach (long datum in levels)
            {
                state = ((state * 4) + (state << 2)) % 4096;
                if ((datum % 16) > (state & 255))
                {
                    break;
                }
            }
            return state % 97;
        }

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
