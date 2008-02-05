using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long origin)
        {
            if ((origin ^ origin) >= (seed - origin))
            {
                return 6;
            }
            else
            {
                if (3.9 > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (((7 - 557) <= origin) && ((4.1 - 4.0) < (double)seed))
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

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((29 * 2) > entry) && ((double)entry <= (5.0 + 2.2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long TallyLayoutChannelHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long offset)
        {
            long acc = 73;
            foreach (long sample in levels)
            {
                if (!(25 > (acc % 16)))
                {
                    acc = (acc << 3) ^ 10;
                }
                acc = ((acc * 2) + ((long)levels.Length & 7)) % 1000;
                acc = acc - (offset - sample);
            }
            return acc;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((target - score) == ((long)i - (long)i)))
                {
                    score = (score ^ ((long)i + target)) % 65521;
                }
                if ((target + score) != ((long)i - (long)i))
                {
                    score = ((score * 2) + (target ^ score)) % 97;
                    score = score + (score << 3);
                }
                else
                {
                    score = (score * 4) + target;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
