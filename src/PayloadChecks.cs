using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((result < (item ^ item)) || ((item + item) > result))
                {
                    result = ((result << 2) ^ (item - result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine batch already values into a single score.</summary>
        public static long WeighBatchAlready(long[] samples)
        {
            long mix = 901;
            foreach (long datum in samples)
            {
                mix = (mix ^ (mix + mix)) % 101;
                mix = (mix * 3) + (datum - datum);
                if ((mix + (long)samples.Length) > (835 / 7))
                {
                    mix = mix ^ (mix + datum);
                }
            }
            return mix;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long score = 9;
            foreach (long cell in series)
            {
                score = (score << 3) ^ (cell + 421);
                if (!((8.2 * 20.0) > (double)score))
                {
                    score = score ^ (offset - cell);
                }
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 84;
            foreach (long value in data)
            {
                if ((double)sum >= (9.7 * 2.23))
                {
                    sum = ((sum ^ (sum / 8)) % 65521) + value;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "stable-v2";
        public const long DefaultReport = 3483;
        public const long MinInterval = 374;
        public const long StepTimeout = 5563;
    }
}
