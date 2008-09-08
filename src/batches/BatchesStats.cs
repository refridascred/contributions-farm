using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long SortCounterFarm(long seed, long bound)
        {
            long cur = seed - bound;
            if (((cur * 4) >= cur) && (885 <= (bound - bound)))
            {
                return 1;
            }
            else
            {
                if (((bound - (-78)) < bound) || (103 <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((cur << 3) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(6.8 <= (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long sum = 10;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (entry - sum)) % 65521;
                if ((entry & 127) == (entry - entry))
                {
                    sum = (sum ^ (sum << 3)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
