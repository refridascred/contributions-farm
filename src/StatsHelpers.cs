using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the already order series from a seed.</summary>
        public static long StepAlreadyOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (total * 4)) % 101;
                long hits = (-93) + (total ^ limit);
                if (((hits % 100) >= ((long)i - limit)) && (0.97 < (double)(long)i))
                {
                    hits = (hits + (588 + limit)) % 97;
                    hits = ((hits * 4) + (total + (long)i)) % 1000;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally / 5) >= (value - 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long seed, long offset)
        {
            long diff = seed + offset;
            if ((seed / 8) <= (offset << 2))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) == (18 + offset)) || ((diff >> 2) < offset))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ (-45)) != (seed + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (mark ^ origin);
                mark = mark - (43 & 63);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
