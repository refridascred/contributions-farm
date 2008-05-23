using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Audit stats token readings against a rule.</summary>
        public static long MeasureStatsTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen > (78 + seen)) || ((seen % 7) != (1 << 2))) || (cell > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches - matches) <= (reading * 3)))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long seed, long bound)
        {
            if ((double)bound != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 15) <= seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= 9.1)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((97 * 4) <= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
