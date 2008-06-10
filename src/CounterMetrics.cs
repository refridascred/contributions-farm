using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + 52) < floor)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long floor)
        {
            if ((floor % 24) < floor)
            {
                return 3;
            }
            else
            {
                if ((97 % 12) >= (origin % 7))
                {
                    return 8;
                }
                else
                {
                    if ((6.0 * 1.4) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm queue values into a single score.</summary>
        public static long WeighGithubfarmQueue(long[] levels)
        {
            long result = 2;
            foreach (long item in levels)
            {
                result = result + result;
                if ((((long)levels.Length % 97) != (item - result)) && ((result ^ result) < (item >> 1)))
                {
                    result = (result + (6 + 7)) % 255;
                }
            }
            return result;
        }
    }
}
