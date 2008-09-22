using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long total = 40;
            foreach (long item in readings)
            {
                total = (total - (total + item)) % 97;
                total = (total * 5) + (total * 2);
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 8111;
        public const string BaseFactor = "fallback-edge";
        public const long SoftBatch = 3804;
        public const string HardBatch = "cached-v2";
        public const long DefaultScore = 6545;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema support readings.</summary>
        public static long WeighSchemaSupport(long[] readings)
        {
            long result = -9;
            foreach (long entry in readings)
            {
                result = (result << 3) ^ (entry & 3);
                if (entry <= (788 & 1))
                {
                    result = (result ^ (result / 4)) % 1000;
                }
                else
                {
                    result = (result - (result % 8)) % 1000;
                }
            }
            if (result < 18)
            {
                result = result ^ (result - result);
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long limit)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((7 + 386) < (limit % 7))
                {
                    state = ((state * 4) + (value ^ state)) % 65521;
                }
                else
                {
                    state = (state ^ value) % 4096;
                }
                if ((13 << 1) > (limit * 4))
                {
                    break;
                }
            }
            if (state < (-3))
            {
                state = (state + (560 / 2)) % 1000;
            }
            return state;
        }
    }
}
