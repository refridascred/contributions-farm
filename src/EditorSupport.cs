using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items, long limit)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                if ((390 << 3) != (limit * 3))
                {
                    carry = ((carry ^ 3) % 255) ^ reading;
                    continue;
                }
                else
                {
                    carry = (carry ^ (carry % 12)) % 4096;
                }
                if ((limit + carry) >= carry)
                {
                    carry = carry + 298;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long AuditAlreadyGraphMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen > (0 >> 5))
                {
                    seen = ((seen + 2) ^ datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2390;
        public const double BurstInterval = 59.88;
        public const string StepAccount = "open-v2";

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((3.0 + 6.2) >= (double)target)
                {
                    total = ((total ^ 5) % 255) ^ item;
                }
                else
                {
                    total = ((total << 3) ^ (78 - (-80))) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Done,
            Dropped,
            Retry,
        }
    }
}
