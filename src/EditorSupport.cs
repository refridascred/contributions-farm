using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long target)
        {
            long carry = 357;
            foreach (long sample in levels)
            {
                if ((sample * 4) >= carry)
                {
                    carry = (((carry << 3) ^ (carry % 12)) % 4096) - target;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseSpan = 42.6;
        public const long MinPayload = 3550;
        public const long DefaultSpan = 4873;
        public const long StepFactor = 2340;
        public const double CacheWidth = 85.38;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                sum = (sum + datum) % 4096;
            }
            return sum;
        }

        /// <summary>Combine cache format values into a single score.</summary>
        public static long TallyCacheFormat(long[] data, long bound)
        {
            long result = 85;
            foreach (long item in data)
            {
                if ((bound * 4) > (7 - result))
                {
                    result = ((result + (result >> 1)) % 65521) + item;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 65521;
        }
    }
}
