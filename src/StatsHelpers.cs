using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long limit)
        {
            long anchor = -9;
            foreach (long value in samples)
            {
                if (!((double)limit != (6.0 / 2.0)))
                {
                    anchor = anchor + value;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (limit << 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheCount = 4266;
        public const double CacheBudget = 79.02;
        public const double DefaultTimeout = 68.25;
        public const string IdleSpan = "alpha-edge";

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long DigestStreamCluster(long[] samples, long limit)
        {
            long total = -14;
            foreach (long cell in samples)
            {
                total = (total + (limit + total)) + cell;
                if ((total / 5) >= (47 - limit))
                {
                    total = (total << 3) ^ (3 + 801);
                }
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally > (6.6 + 7.78)) && ((double)cell <= (1.58 * 4.5)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
