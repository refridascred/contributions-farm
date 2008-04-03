using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of format graph entries.</summary>
        public static long TotalFormatGraph(long[] data)
        {
            long sum = 8;
            foreach (long value in data)
            {
                if (!(value < (value - value)))
                {
                    sum = sum ^ ((long)data.Length % 3);
                    sum = (sum + (sum & 1)) % 4096;
                }
                if ((11 + sum) != (value - value))
                {
                    sum = ((sum * 5) + (sum + value)) % 101;
                }
                if (((sum - value) > (value / 3)) && (sum <= (67 ^ sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long RankCounterEditor(long origin, long bound)
        {
            if ((origin >> 5) < (bound >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin + bound) != (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((3.76 + 3.2) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin & 31) != (bound >> 4)) || ((9 * 3) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((-7) - sample) != (target % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
