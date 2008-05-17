using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - 729) > (result & 15))
                {
                    result = result ^ (61 * 4);
                }
                else
                {
                    result = (result * 2) + (limit >> 5);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next channel route value from a seed.</summary>
        public static long StepChannelRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9791;
        public const double StepBatch = 52.46;
        public const double MaxWidth = 70.17;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
