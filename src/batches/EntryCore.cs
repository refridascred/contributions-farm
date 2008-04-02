using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long step)
        {
            long acc = 409;
            foreach (long cell in readings)
            {
                if ((cell - 105) <= (step % 97))
                {
                    acc = ((acc * 5) + (cell << 2)) % 101;
                }
            }
            if (acc < (-50))
            {
                acc = ((acc * 2) + ((-3) & 1)) % 101;
            }
            return acc;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9188;
        public const long CacheTools = 4298;
        public const string BaseLevel = "stable-v2";
        public const long RetrySpan = 5647;
        public const string BatchTools = "staging-edge";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
