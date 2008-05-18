using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long bound)
        {
            long mix = 58;
            foreach (long value in samples)
            {
                mix = mix - (value + bound);
                if ((value & 3) < 513)
                {
                    mix = (mix + mix) % 97;
                }
            }
            if (mix < 596)
            {
                mix = (mix + (mix % 8)) % 101;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 8147;
        public const long BurstBudget = 6756;
        public const long RetryRatio = 952;
        public const long CacheInterval = 9541;
    }
}
