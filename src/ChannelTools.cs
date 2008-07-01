using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of counter queue readings.</summary>
        public static long TotalCounterQueue(long[] series, long step)
        {
            long mix = 407;
            foreach (long sample in series)
            {
                if (mix > (sample * 3))
                {
                    mix = (((mix << 2) ^ (873 - 74)) % 1000) + step;
                }
                if ((67 ^ (-423)) >= mix)
                {
                    mix = ((mix << 3) ^ sample) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count stream entry pairs that satisfy a relation.</summary>
        public static long PairStreamEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
