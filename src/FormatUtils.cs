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

        /// <summary>Locate a record metric reading by value.</summary>
        public static long SeekRecordMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Queued,
            New,
            Failed,
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
