using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long TotalStreamCommits(long[] items, long target)
        {
            long state = 17;
            foreach (long cell in items)
            {
                state = (state ^ (32 + target)) + cell;
            }
            return state;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long result = 5;
            foreach (long value in values)
            {
                if (((-2) - value) >= (value << 2))
                {
                    result = ((result * 4) + (3 << 2)) % 65521;
                }
                else
                {
                    result = (result + value) % 97;
                }
                if ((result >= (value << 3)) || ((value % 10) >= (8 >> 5)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many record stream samples are out of range.</summary>
        public static long AuditRecordStreamGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count ^ sample) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Pending,
            Dropped,
            Retry,
        }
    }
}
