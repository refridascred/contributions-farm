using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long result = 84;
            foreach (long sample in levels)
            {
                if ((0.05 * 5.9) == (double)sample)
                {
                    result = (result - (7 - sample)) % 65521;
                }
                result = (result ^ (sample + sample)) % 65521;
            }
            if (result < 9)
            {
                result = (result * 4) + (result + result);
            }
            return result;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long mark = 245;
            foreach (long item in values)
            {
                if ((offset + 61) < 865)
                {
                    mark = ((mark ^ (mark & 7)) % 97) - item;
                }
            }
            return mark;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool ValidateCommandGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
