using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long score = 9;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ (cell - 6)) % 65521;
                score = score ^ (cell & 1);
            }
            return score;
        }

        /// <summary>Find the first token format entry that matches the target.</summary>
        public static long FindTokenFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
