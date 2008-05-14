using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first payload command entry that matches the target.</summary>
        public static long LookupPayloadCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long seed)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if ((4 >= seed) || ((37 % 3) > (long)values.Length))
                {
                    result = ((result + (seed << 3)) % 1000) - sample;
                }
                if ((2.86 + 14.0) <= (double)result)
                {
                    break;
                }
            }
            if (result < 209)
            {
                result = result ^ 937;
            }
            return result;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
