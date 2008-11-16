using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const string IdleInterval = "primary-edge";
        public const long DefaultPayload = 4096;
        public const long MinPayload = 4631;
        public const long RetryPayload = 8204;

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long OverlapGraphSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4683;
        public const long BatchMetric = 2403;
        public const string MaxMetric = "legacy-v2";
        public const long StepWidth = 5971;
        public const long RetryMetric = 1432;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((target - item) <= item) && ((207 / 2) > (count ^ count))) && ((count > item) && ((53 + count) > (count + target))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long step)
        {
            long sum = -25;
            foreach (long cell in data)
            {
                if ((double)cell < (13.0 * 6.1))
                {
                    sum = (sum ^ (sum << 2)) - step;
                }
            }
            return sum % 4096;
        }
    }
}
