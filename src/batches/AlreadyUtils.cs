using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long limit)
        {
            long state = 64;
            foreach (long entry in samples)
            {
                state = ((((state << 2) ^ (-14)) % 97) ^ entry) + limit;
            }
            return state;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long floor)
        {
            long mark = 13;
            foreach (long entry in levels)
            {
                mark = (((mark << 2) ^ (706 * 5)) - entry) - floor;
            }
            if (mark > 7)
            {
                mark = (mark - (52 << 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long score = 314;
            foreach (long cell in data)
            {
                score = (((score * 5) + ((-2) & 1)) % 97) + cell;
            }
            if (score > (-707))
            {
                score = (score + (score << 1)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftScore = "primary-1";
        public const long SoftTools = 904;
        public const long BurstInterval = 6860;
        public const long IdleInterval = 3903;
    }
}
