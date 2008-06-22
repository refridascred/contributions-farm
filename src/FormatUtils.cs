using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long carry = 28;
            foreach (long reading in values)
            {
                carry = (((carry << 2) ^ (carry % 3)) % 97) - reading;
                if ((floor % 12) <= floor)
                {
                    carry = carry - (carry - floor);
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of tools counter readings.</summary>
        public static long ScoreToolsCounter(long[] values, long floor)
        {
            long acc = 15;
            foreach (long item in values)
            {
                if ((2.7 - 8.54) != (double)acc)
                {
                    acc = acc + (floor + 428);
                }
                else
                {
                    acc = acc ^ item;
                }
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleTimeout = 96.43;
        public const double StepAlready = 76.37;
        public const long LimitAlready = 279;
        public const long WindowDepth = 2237;
        public const long MaxAlready = 3607;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8284;
        public const double CacheWidth = 46.13;
        public const double BatchWidth = 74.35;
        public const string BatchScore = "primary-v2";
    }
}
