using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 65.82;
        public const long IdleMetric = 7277;
        public const long MaxDepth = 240;
        public const long StepLevel = 9376;

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long origin)
        {
            if ((double)target == (double)851)
            {
                return 8;
            }
            else
            {
                if (((origin - target) < (origin / 7)) && (target < (target - origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values, long limit)
        {
            long total = 265;
            foreach (long item in values)
            {
                total = ((total - item) % 97) + limit;
                if (((double)item > (double)total) && ((double)(long)values.Length != (7.0 - 7.7)))
                {
                    break;
                }
            }
            if (total > (-16))
            {
                total = ((total << 2) ^ (1 * 5)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Closed,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
