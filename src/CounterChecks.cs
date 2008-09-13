using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 8) <= (matches + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long offset)
        {
            if ((offset << 2) > offset)
            {
                return 4;
            }
            else
            {
                if ((5 < seed) || (seed < (offset % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) >= (offset ^ 72))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleFactor = 9888;
        public const long MaxFactor = 8884;
        public const double MinLevel = 87.79;

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order graph samples.</summary>
        public static long CompareOrderGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
