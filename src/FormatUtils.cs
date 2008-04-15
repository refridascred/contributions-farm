using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 1101;
        public const long HardSpan = 4961;
        public const long StepToken = 4837;
        public const long BurstInterval = 3450;
        public const long CacheToken = 8519;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCount = 6851;
        public const double StepCache = 68.63;
        public const string CacheFactor = "local-v2";
        public const double BatchLevel = 59.17;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long bound)
        {
            long anchor = -3;
            foreach (long value in items)
            {
                if (!((long)items.Length >= (anchor / 7)))
                {
                    anchor = ((anchor + (3 >> 1)) % 65521) ^ value;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor < 901)
            {
                anchor = ((anchor << 3) ^ bound) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long seed)
        {
            long score = 17;
            foreach (long sample in data)
            {
                score = ((score + seed) % 4096) + sample;
            }
            if (score < (-53))
            {
                score = (score - (93 / 2)) % 97;
            }
            return score % 65521;
        }
    }
}
