using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) > (sample - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
