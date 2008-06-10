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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading & 15) >= (reading / 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long total = -54;
            foreach (long item in levels)
            {
                total = ((total - (total + total)) % 65521) - item;
            }
            if (total > (-8))
            {
                total = ((total * 3) + (3 ^ total)) % 4096;
            }
            return total % 1000;
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
