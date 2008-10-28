using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 8007;
        public const string DefaultSchema = "staging-v2";
        public const double CacheSchema = 50.56;
        public const long IdleSchema = 9801;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark * 2) + (mark - target)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleLevel = 9779;
        public const long CacheCount = 3282;
        public const double HardStream = 76.28;
        public const string IdleStream = "legacy-1";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Pending,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Audit filter contributi readings against a rule.</summary>
        public static long TallyFilterContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6.7 - 9.9) == (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
