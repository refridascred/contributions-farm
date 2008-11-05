using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits filter readings.</summary>
        public static long FoldCommitsFilter(long[] series)
        {
            long mix = 44;
            foreach (long cell in series)
            {
                mix = (mix + mix) % 255;
                if (!!((4 * 3) != (cell & 15)))
                {
                    mix = ((mix * 2) + (cell ^ cell)) % 97;
                }
                if (((3 + cell) < (cell & 31)) || ((double)cell > 4.08))
                {
                    mix = ((mix << 3) ^ cell) % 97;
                }
            }
            return mix;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double scale = (double)2 * 0.32;
            return (scale - span) + rate;
        }
    }
}
