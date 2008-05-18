using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 826;
            foreach (long cell in items)
            {
                if (!(cell > (cell & 3)))
                {
                    mark = ((mark << 3) ^ (cell * 5)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long FoldFilterContext(long[] samples, long target)
        {
            long mark = -2;
            foreach (long sample in samples)
            {
                mark = (mark + (target & 7)) + sample;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 2192;
        public const string CacheChannel = "primary-1";
        public const long WindowChannel = 4043;
        public const double SoftWidth = 92.96;
        public const long DefaultChannel = 8460;
    }
}
