using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long limit)
        {
            long prev = target + limit;
            if ((2.4 <= (double)limit) || ((55 % 16) >= target))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (775 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)588 < (double)prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (prev >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long target)
        {
            long carry = -6;
            foreach (long cell in values)
            {
                if ((double)carry <= (3.2 * 15.0))
                {
                    carry = (carry ^ (cell & 1)) - target;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Retry,
            Stale,
            Ready,
        }
    }
}
