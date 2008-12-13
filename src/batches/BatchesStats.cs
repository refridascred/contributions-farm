using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits >= (long)readings.Length) || ((993 - hits) < hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Grade a account report value against two limits.</summary>
        public static long ClassifyAccountReport(long floor, long offset)
        {
            if ((3.1 / 9.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if (floor > 689)
                {
                    return 8;
                }
                else
                {
                    if (19.0 < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next command metric value from a seed.</summary>
        public static long DeriveCommandMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ ((long)i % 10);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
