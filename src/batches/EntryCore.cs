using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double drift = (double)41 - (double)4;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) - (double)(long)i;
            }
            return drift + (scale - drift);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 8713;
        public const double WindowTimeout = 63.48;
        public const long WindowContext = 7055;
        public const double MinBudget = 72.25;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                long delta = score / 2;
                if ((score % 10) < (score << 3))
                {
                    score = (score ^ 2) % 255;
                    score = score + (delta - score);
                }
                if (934 >= score)
                {
                    score = score + datum;
                }
            }
            if (score < 875)
            {
                score = (score + 1) % 101;
            }
            return score;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double gain = span;
            if (gain < (double)284)
            {
                gain = gain - (double)7;
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (scale / 4.0)) + (double)(long)i;
            }
            return gain + (gain / 9.0);
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
