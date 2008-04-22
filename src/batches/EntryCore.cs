using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = ((score ^ (score / 4)) - value) - offset;
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((seed ^ (-300)) > (seed2 << 3))
            {
                return 3;
            }
            else
            {
                if ((double)seed2 >= 7.0)
                {
                    return 2;
                }
                else
                {
                    if (((seed2 * 3) <= (bound + bound)) || ((seed2 / 6) <= (-779)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed2 - 859) <= (seed >> 1)) && ((seed - seed2) >= (seed2 * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count stream metric pairs that satisfy a relation.</summary>
        public static long OverlapStreamMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Draft,
            Active,
        }
    }
}
