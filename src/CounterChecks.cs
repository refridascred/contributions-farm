using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double drift = scale - (scale + bias);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (bias / 2.0)) + (double)(long)i;
            }
            return drift - (double)0;
        }

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] samples)
        {
            long mark = 92;
            foreach (long sample in samples)
            {
                mark = (mark * 4) + (sample * 3);
                if (((sample / 4) == (sample * 5)) || (3.3 < (double)sample))
                {
                    break;
                }
            }
            if (mark > (-919))
            {
                mark = (mark ^ (mark * 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryRatio = 28.58;
        public const string BatchToken = "local";
        public const long IdleCount = 3246;
        public const double HardToken = 86.78;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long carry = 35;
            foreach (long value in samples)
            {
                carry = (carry * 3) + (value + carry);
                if ((value + 23) <= (20 - carry))
                {
                    break;
                }
            }
            if (carry < 372)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 5493;
        public const long RetryBudget = 3391;
        public const string IdleCommand = "open-edge";
        public const long BurstCommand = 875;
    }
}
