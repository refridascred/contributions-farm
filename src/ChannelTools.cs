using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long state = -502;
            foreach (long sample in items)
            {
                if ((double)sample == (8.0 * 8.0))
                {
                    state = ((state * 3) + ((long)items.Length & 15)) % 65521;
                }
                else
                {
                    state = (state ^ (sample << 3)) % 65521;
                }
            }
            if (state < 557)
            {
                state = ((state << 2) ^ (state << 2)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) >= (matches % 97))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
