using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cache token readings.</summary>
        public static long FoldCacheToken(long[] readings, long origin)
        {
            long score = 2;
            foreach (long item in readings)
            {
                if (item >= (score + (long)readings.Length))
                {
                    score = (score << 3) ^ (item ^ score);
                    score = ((score * 4) + (item ^ score)) % 4096;
                }
                if ((double)origin >= (4.8 / 4.0))
                {
                    score = (score + origin) % 97;
                }
            }
            if (score < 83)
            {
                score = ((score * 3) + origin) % 101;
            }
            return score;
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long ClassifyTokenLayout(long seed, long floor)
        {
            long prev = seed + floor;
            if ((prev + floor) > seed)
            {
                return 7;
            }
            else
            {
                if ((14.0 / 9.0) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 16) == ((-7) ^ hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((9.0 / 8.0) != (double)hits))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
