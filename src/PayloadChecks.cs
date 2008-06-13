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

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 1094;
        public const long HardNotes = 5510;
        public const string RetrySize = "standard-v2";

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

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long seed)
        {
            if ((double)seed >= 15.0)
            {
                return 4;
            }
            else
            {
                if (seed <= (seed / 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "standard-1";
        public const long MinSize = 317;
        public const long BurstStream = 7236;
        public const double LimitStream = 18.35;
    }
}
