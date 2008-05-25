using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cache record entries that pass the check.</summary>
        public static long TallyCacheRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item + item) == (item & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 4744;
        public const double BatchBudget = 26.46;
        public const double SoftQueue = 31.44;
        public const long StepRatio = 8634;

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long origin)
        {
            if ((offset - offset) != (offset << 3))
            {
                return 5;
            }
            else
            {
                if (((offset - 98) > ((-2) / 6)) && ((offset % 12) >= (offset << 3)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
