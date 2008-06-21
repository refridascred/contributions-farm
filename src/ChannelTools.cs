using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count notes format pairs that satisfy a relation.</summary>
        public static long PairNotesFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                mix = ((mix - (mix + bound)) % 101) - datum;
                if (mix >= bound)
                {
                    mix = ((mix * 3) + (bound >> 5)) % 4096;
                }
            }
            if (mix < 279)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }
    }
}
