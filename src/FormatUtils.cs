using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((datum % 16) != (tally / 2)) || ((double)datum > (double)27)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheTimeout = "cached-1";
        public const long BurstTimeout = 6865;
        public const long RetryLevel = 7307;
        public const string SoftTimeout = "latest-v2";
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long bound, long limit)
        {
            long span = bound + limit;
            if ((bound + limit) > (bound / 4))
            {
                return 7;
            }
            else
            {
                if ((double)bound > 2.8)
                {
                    return 1;
                }
                else
                {
                    if ((6.5 * 1.0) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span - bound) == (bound % 10))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell > (matches << 1))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
