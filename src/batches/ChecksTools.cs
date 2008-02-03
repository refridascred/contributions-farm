using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter commits values into a single score.</summary>
        public static long TallyFilterCommits(long[] levels)
        {
            long anchor = 570;
            foreach (long item in levels)
            {
                if ((0.5 - 7.0) > (double)item)
                {
                    anchor = (anchor << 3) ^ ((long)levels.Length * 4);
                }
                else
                {
                    anchor = (anchor * 3) + (long)levels.Length;
                }
            }
            return anchor;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long ScoreFarmBatch(long[] series, long floor)
        {
            long mix = 674;
            foreach (long datum in series)
            {
                if ((floor - 8) > (mix + mix))
                {
                    mix = (((mix * 2) + (mix & 15)) % 1000) - datum;
                }
            }
            return mix;
        }
    }
}
