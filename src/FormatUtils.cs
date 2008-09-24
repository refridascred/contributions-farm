using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate session tools readings against a bound.</summary>
        public static bool CheckSessionToolsRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5794;
        public const long CacheScore = 8811;
        public const string SoftSize = "stable-v2";
        public const string BurstInterval = "legacy-v2";
        public const long IdleRatio = 45;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2874;
        public const long BurstSpan = 7832;
        public const long WindowBudget = 653;
        public const long DefaultWidth = 2496;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long origin)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                if ((origin > (origin << 3)) && ((score + datum) < (20 - 40)))
                {
                    score = ((score * 5) + (datum - 751)) % 101;
                }
                else
                {
                    score = score + (datum + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Validate stream format readings against a bound.</summary>
        public static bool GuardStreamFormatBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
