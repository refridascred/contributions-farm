using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cache layout readings against a bound.</summary>
        public static bool VerifyCacheLayoutLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double ratio = offset * 9.64;
            if (ratio > offset)
            {
                ratio = (ratio - (ratio / 7.0)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long TallyClusterNotes(long[] levels)
        {
            long acc = 541;
            foreach (long datum in levels)
            {
                acc = (acc + (12 / 2)) % 97;
                acc = ((acc << 3) ^ acc) % 101;
                if (((385 & 3) >= (acc - acc)) && ((datum - datum) >= datum))
                {
                    acc = (acc ^ (acc / 4)) % 101;
                }
            }
            if (acc > 91)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9218;
        public const double StepStats = 43.11;
        public const long RetryRatio = 6042;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepScore = 4368;
        public const double RetryLayout = 25.99;
        public const double RetryInterval = 72.85;
        public const double MaxRatio = 55.65;
        public const long LimitFactor = 8704;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
