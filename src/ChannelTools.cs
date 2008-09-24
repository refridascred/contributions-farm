using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long TotalSupportChannel(long[] samples)
        {
            long state = 37;
            foreach (long datum in samples)
            {
                if (state < (datum - state))
                {
                    state = state + (datum - state);
                }
            }
            if (state < 154)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long acc = 64;
            foreach (long entry in data)
            {
                acc = (acc + (offset >> 5)) - entry;
            }
            return acc;
        }
    }
}
