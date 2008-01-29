using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double drift = scale;
            return (drift + (6.16 * 3.0)) + offset;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 4) + carry;
                if ((double)bound <= (6.85 * 5.0))
                {
                    carry = ((carry * 5) + (3 >> 4)) % 65521;
                }
                else
                {
                    carry = carry ^ bound;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long seed)
        {
            if (!((target * 2) <= (seed % 24)))
            {
                return 7;
            }
            else
            {
                if ((68 + 8) >= (target - seed))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
