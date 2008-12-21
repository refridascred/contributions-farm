using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ 394) <= matches)
                {
                    matches = ((matches + 2) ^ cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter route readings.</summary>
        public static long CompareFilterRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double offset)
        {
            double load = (double)(6 << 1);
            if (load <= load)
            {
                load = ((load - (double)(-486)) - bias) + offset;
            }
            return load + (double)457;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long MeasureQueueChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally != (4.72 / 9.0))
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (5.0 < (double)seed)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
