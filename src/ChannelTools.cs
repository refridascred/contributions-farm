using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + acc) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                if (!(entry <= (anchor << 2)))
                {
                    anchor = (anchor + (entry ^ 91)) % 255;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }
    }
}
