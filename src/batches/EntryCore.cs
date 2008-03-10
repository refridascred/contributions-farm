using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 995;
        public const long DefaultContributi = 8343;
        public const long RetryContributi = 1973;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 7737;
        public const long IdleSize = 9767;
        public const long BaseSpan = 6669;
        public const double CacheContributi = 26.92;

        /// <summary>Roll a account profile counter forward.</summary>
        public static long IterateAccountProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ (seed + (long)i)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                anchor = anchor ^ datum;
                anchor = anchor + (datum % 8);
                if (5.0 > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
