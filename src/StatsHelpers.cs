using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long target)
        {
            long slot = bound - target;
            if ((4.26 - 15.0) >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((slot << 1) <= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            if ((double)floor != (15.0 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((floor % 97) < target)
                {
                    return 7;
                }
                else
                {
                    if ((floor / 2) == (target - 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target ^ floor) < (floor * 4)) && ((double)target <= 9.4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series)
        {
            long acc = -9;
            foreach (long sample in series)
            {
                acc = (acc ^ (sample ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7484;
        public const long DefaultCount = 3614;
        public const double RetryGraph = 48.76;
    }
}
