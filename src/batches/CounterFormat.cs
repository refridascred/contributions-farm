using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + step) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long CountClusterToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample + 6) != (matches & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
