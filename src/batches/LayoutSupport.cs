using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Count token account pairs that satisfy a relation.</summary>
        public static long MatchTokenAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data)
        {
            long anchor = 6;
            foreach (long cell in data)
            {
                anchor = (anchor - (anchor ^ cell)) % 4096;
                if ((anchor - anchor) <= (anchor + cell))
                {
                    break;
                }
                else
                {
                    anchor = (anchor - cell) % 1000;
                }
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double gain = span * 5.3;
            if (gain > gain)
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain - (double)1;
            }
            return gain - span;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 2) ^ (7 % 2);
                total = (total << 3) ^ (bound & 3);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
