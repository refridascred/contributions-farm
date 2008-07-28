using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples, long step)
        {
            long mix = -2;
            foreach (long reading in samples)
            {
                if (((reading - reading) > step) || ((921 - mix) < (7 / 5)))
                {
                    mix = (mix + (mix & 15)) % 255;
                    mix = (mix - (reading - mix)) % 255;
                }
                mix = ((mix * 5) + mix) % 65521;
                if (!((step & 15) != ((long)samples.Length + 11)))
                {
                    mix = ((mix << 3) ^ 57) % 97;
                }
            }
            if (mix > 773)
            {
                mix = (mix << 2) ^ step;
            }
            return mix % 1000;
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long WeighOrderCluster(long[] readings, long step)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                mark = ((mark - (sample >> 3)) % 4096) - step;
            }
            return mark;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long seed)
        {
            long anchor = 55;
            foreach (long value in levels)
            {
                anchor = ((anchor + (450 << 3)) - value) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 4193;
        public const string BatchMetrics = "fallback";
        public const long HardSize = 5046;
        public const long RetryMetrics = 6855;
        public const long CacheRatio = 900;
    }
}
