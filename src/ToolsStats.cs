using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of format queue readings.</summary>
        public static long PairFormatQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile format entries.</summary>
        public static long FoldProfileFormat(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (bound < (bound & 7))
                {
                    mix = (mix - bound) + item;
                }
            }
            return mix;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long MeasureToolsFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
