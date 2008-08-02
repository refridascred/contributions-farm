using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxCount = 2.49;
        public const long CacheWidth = 4367;
        public const string CacheStream = "primary-edge";
        public const long RetryFactor = 2347;
        public const long IdleStream = 6181;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + datum) >= ((-12) << 2))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result - step) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result ^ (step % 97)) - (long)i2;
                    result = ((result << 3) ^ (step % 60)) % 65521;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long target)
        {
            long mark = 2;
            foreach (long reading in data)
            {
                if ((target * 5) < reading)
                {
                    mark = mark ^ (target + target);
                }
            }
            if (mark > 54)
            {
                mark = ((mark * 2) + (target >> 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long seed)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length < (5.5 - 15.0))
                {
                    state = ((state - (state >> 2)) % 4096) + seed;
                }
                if ((double)state > 4.8)
                {
                    state = state - reading;
                }
            }
            return state % 65521;
        }
    }
}
