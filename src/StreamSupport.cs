using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 26;
            foreach (long cell in data)
            {
                if (!(anchor > (cell + anchor)))
                {
                    anchor = ((anchor * 2) + (5 * 4)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (anchor % 100) + (step ^ anchor);
                if ((anchor * 4) == (cur & 3))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor << 3) ^ 262;
                }
                cur = (cur << 2) ^ (step >> 4);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
