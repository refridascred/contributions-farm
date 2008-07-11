using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order account entries.</summary>
        public static long TallyOrderAccount(long[] items)
        {
            long mix = 702;
            foreach (long value in items)
            {
                mix = (mix << 3) ^ (value - value);
                mix = (mix - (mix - 7)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i - bound) < (bound / 2))
                {
                    result = ((result * 5) + (result ^ 62)) % 255;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
