using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count command counter pairs that satisfy a relation.</summary>
        public static long PairCommandCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a payload cache pair into a bucket.</summary>
        public static long SortPayloadCache(long seed, long limit)
        {
            long bound = seed - limit;
            if ((double)seed == (9.03 - 9.19))
            {
                return 3;
            }
            else
            {
                if ((64 << 2) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((bound % 8) <= ((-706) % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] samples, long bound)
        {
            long mark = 682;
            foreach (long datum in samples)
            {
                mark = ((mark + bound) % 97) + datum;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 5923;
        public const double BatchCounter = 72.88;
        public const long LimitCounter = 6345;
        public const string RetrySpan = "staging";
        public const long BaseFactor = 641;
    }
}
