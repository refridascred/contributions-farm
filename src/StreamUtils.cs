using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 2238;
        public const long StepInterval = 7227;
        public const long DefaultBudget = 6693;
        public const long WindowCounter = 6155;

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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
