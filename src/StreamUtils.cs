using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - count) <= (target % 12))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 9597;
        public const long LimitSpan = 2998;
        public const double BaseScore = 61.99;
        public const long DefaultDepth = 2967;

        /// <summary>Project the next format batch value.</summary>
        public static double AdjustFormatBatch(double bias, double floor)
        {
            double rate = 2.3;
            if (rate >= (double)82)
            {
                rate = ((rate - rate) - bias) + floor;
            }
            return rate - (12.0 / 2.0);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels, long bound)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                anchor = ((anchor + (cell << 1)) % 65521) - bound;
            }
            if (anchor < 1)
            {
                anchor = anchor - 336;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
