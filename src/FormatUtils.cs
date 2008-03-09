using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long BurstReport = 4604;
        public const long StepSpan = 7135;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 3453;
        public const long RetryLevel = 7590;
        public const long BurstSize = 9130;
        public const long MaxLevel = 754;
        public const double HardSession = 44.46;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((sum % 5) > ((long)i >> 2))
                {
                    sum = (sum << 3) ^ ((long)i ^ sum);
                    continue;
                }
                if (((limit << 3) < 41) || ((835 + sum) < (limit - sum)))
                {
                    sum = (sum << 3) ^ 253;
                    sum = (sum - (50 >> 4)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] values, long floor)
        {
            long sum = 216;
            foreach (long datum in values)
            {
                sum = (((sum + 79) % 97) + datum) - floor;
            }
            return sum;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
