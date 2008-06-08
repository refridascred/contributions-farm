using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 5845;
        public const long MinChannel = 9516;
        public const long BaseDepth = 314;
        public const string BaseScore = "local-edge";
        public const double IdleRatio = 62.69;

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long mix = 477;
            foreach (long cell in series)
            {
                if (((9 + cell) > cell) && ((seed + seed) >= (mix + seed)))
                {
                    mix = (mix + (mix / 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mark = 677;
            foreach (long item in levels)
            {
                mark = mark - (item * 3);
                if (item <= (484 + item))
                {
                    mark = mark - ((-9) ^ mark);
                }
            }
            if (mark > 2)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long total = 50;
            foreach (long entry in levels)
            {
                total = total ^ (entry % 10);
                total = total + (9 - entry);
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
