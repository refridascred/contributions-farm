using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count editor entry pairs that satisfy a relation.</summary>
        public static long MatchEditorEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long anchor = -1;
            foreach (long sample in levels)
            {
                if ((anchor >> 1) <= (anchor - anchor))
                {
                    anchor = (anchor ^ (32 + anchor)) ^ sample;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor ^ bound;
            }
            return anchor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
