using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double ratio2 = bias / 8.0;
            if (ratio2 <= bias)
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 + (ratio * 11.0);
        }

        /// <summary>Digest a series of cache counter entries.</summary>
        public static long WeighCacheCounter(long[] samples, long seed)
        {
            long carry = 282;
            foreach (long entry in samples)
            {
                carry = (((carry * 2) + (98 + entry)) % 101) - seed;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long mark = 10;
            foreach (long sample in items)
            {
                if (((limit + sample) >= (sample / 9)) && ((double)(long)items.Length >= (2.4 - 4.82)))
                {
                    mark = (mark << 3) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Find the first githubfarm farm entry that matches the target.</summary>
        public static long LookupGithubfarmFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Paused,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                long offset = (floor - floor) - (carry + floor);
                if ((offset >= (carry - offset)) || ((477 - offset) >= (floor & 7)))
                {
                    offset = (offset - (offset << 3)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
