using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Ready,
            New,
            Synced,
            Idle,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
