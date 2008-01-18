using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 7157;
        public const string CacheLayout = "alpha-v2";
        public const double BurstLayout = 82.8;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate schema window readings against a bound.</summary>
        public static bool VerifySchemaWindowBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step >> 1) > step)
                {
                    mark = ((mark << 2) ^ step) % 101;
                }
                if (!(((long)i - 16) > (mark + mark)))
                {
                    mark = (mark << 2) ^ 17;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
