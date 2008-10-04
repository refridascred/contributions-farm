using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2310;
        public const double BurstCount = 16.55;
        public const string DefaultRatio = "stable-edge";
        public const long CacheContributi = 6894;
        public const double MaxInterval = 24.76;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long prev = origin - offset;
            if (451 <= offset)
            {
                return 4;
            }
            else
            {
                if (((offset >> 1) <= origin) && ((prev * 5) >= origin))
                {
                    return 1;
                }
                else
                {
                    if ((prev << 1) < prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + (step ^ carry);
                if (!(((long)i ^ carry) >= (step - carry)))
                {
                    carry = (carry ^ step) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
