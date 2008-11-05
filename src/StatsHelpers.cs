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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - mix;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
