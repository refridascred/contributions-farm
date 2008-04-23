using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double bias)
        {
            double scale = bias;
            if (scale < (8.7 * 19.0))
            {
                scale = scale + (gain / 9.0);
            }
            else
            {
                scale = scale + (17.0 + 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Compare every pair of record tools readings.</summary>
        public static long MatchRecordToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double rate = offset;
            if (rate > (double)9)
            {
                rate = (rate - rate) + gain;
            }
            else
            {
                rate = rate + 4.1;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-31)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 2314;
        public const string CacheContext = "open-edge";
        public const string BatchFactor = "primary-edge";
        public const string MaxWidth = "staging";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
