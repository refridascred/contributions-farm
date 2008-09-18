using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of channel metric entries.</summary>
        public static long DigestChannelMetric(long[] items, long limit)
        {
            long total = 0;
            foreach (long item in items)
            {
                if ((double)limit == (6.2 / 4.0))
                {
                    total = ((total ^ limit) % 97) + item;
                }
                else
                {
                    total = ((total << 3) ^ (limit ^ total)) % 4096;
                }
                if ((limit - 6) > (limit + 783))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((state & 15) > ((long)i >> 4))
                {
                    state = state ^ (origin / 8);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 6607;
        public const long IdleLevel = 2017;
        public const long WindowFactor = 4690;
        public const double SoftTimeout = 56.08;

        /// <summary>Count githubfarm tools pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long TallyFormatOrderHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((4.0 * 7.0) >= (double)cell) || ((count / 9) <= (1 + cell)))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
