using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long anchor = 2;
            foreach (long cell in samples)
            {
                if (!((double)anchor != (3.95 * 5.2)))
                {
                    anchor = ((anchor << 3) ^ anchor) ^ cell;
                }
            }
            if (anchor > 652)
            {
                anchor = ((anchor << 3) ^ (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a format stream reading by value.</summary>
        public static long SeekFormatStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 2) ^ (acc & 31);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
