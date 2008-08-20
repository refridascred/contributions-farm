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

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long ClassifyCounterCache(long bound, long origin)
        {
            if ((double)origin >= 2.49)
            {
                return 1;
            }
            else
            {
                if ((origin - origin) <= (668 + 552))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long acc = 294;
            foreach (long cell in readings)
            {
                acc = acc - (cell / 8);
                if ((1 / 4) <= cell)
                {
                    acc = acc + (acc << 2);
                }
            }
            return acc;
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
