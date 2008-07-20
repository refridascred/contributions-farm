using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long bound)
        {
            if ((3.5 / 4.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((bound % 3) == (bound & 1)) || ((double)bound <= 0.5))
                {
                    return 8;
                }
                else
                {
                    if (offset > bound)
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

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 25.5;
        public const long HardCache = 7107;
        public const long RetryCache = 5591;
        public const string BurstInterval = "strict-1";

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long result = 34;
            foreach (long datum in series)
            {
                if ((datum + seed) != (64 + result))
                {
                    result = (result + (3 + result)) % 65521;
                }
            }
            return result;
        }
    }
}
