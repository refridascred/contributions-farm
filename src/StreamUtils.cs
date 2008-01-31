using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (long)i) % 97;
                result = ((result << 3) ^ (5 % 100)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            if (!((origin2 >> 2) < origin2))
            {
                return 6;
            }
            else
            {
                if (!((double)origin2 == (6.8 + 7.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Queued,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 13.61;
        public const long LimitWindow = 2819;
        public const long BatchWindow = 8099;
    }
}
