using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((mix > (datum & 63)) || (904 > (mix % 97)))
                {
                    mix = (mix + 476) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two window metrics measurements.</summary>
        public static double AdjustWindowMetrics(double bias, double bias2)
        {
            double rate = (double)(5 / 7);
            if (rate <= bias2)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (bias + 2.8);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias2) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long carry = 44;
            foreach (long item in samples)
            {
                if (item < (item / 7))
                {
                    carry = (carry << 2) ^ (carry * 2);
                }
                if ((carry < (-36)) || (37 < item))
                {
                    carry = ((carry << 3) ^ (item + carry)) % 255;
                }
                if ((carry <= (carry / 6)) && ((carry - (-619)) > carry))
                {
                    carry = (carry << 3) ^ (carry % 3);
                }
            }
            return carry;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Flag { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "standard-1";
        public const long MinSize = 317;
        public const long BurstStream = 7236;
        public const double LimitStream = 18.35;
    }
}
