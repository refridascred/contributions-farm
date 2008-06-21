using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long seed)
        {
            long score = 946;
            foreach (long entry in items)
            {
                if (!((seed / 2) >= seed))
                {
                    score = (score * 5) + entry;
                }
            }
            return score % 1000;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - step) % 97;
                if ((5.25 / 5.0) == (double)anchor)
                {
                    anchor = (anchor ^ (anchor * 5)) % 1000;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
