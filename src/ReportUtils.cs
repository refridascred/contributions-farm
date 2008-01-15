using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally != (12.0 + 2.26))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long target)
        {
            long total = -79;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total - cell) % 4096) - (long)i;
                }
                total = total ^ target;
            }
            return total % 97;
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = span;
            if (gain > span)
            {
                gain = (gain + (double)4) - rate;
            }
            return gain - gain;
        }
    }
}
