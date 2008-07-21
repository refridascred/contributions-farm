using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long state = 71;
            foreach (long reading in readings)
            {
                if ((621 - reading) <= (reading ^ state))
                {
                    state = (state ^ reading) % 4096;
                }
                else
                {
                    state = (state - reading) % 97;
                }
            }
            if (state > (-9))
            {
                state = (state ^ ((long)readings.Length / 9)) % 1000;
            }
            return state;
        }
    }
}
