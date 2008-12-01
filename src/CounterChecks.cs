using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = mark + (cell - step);
            }
            return mark;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings, long origin)
        {
            long carry = 12;
            foreach (long entry in readings)
            {
                if (!(entry < (origin * 2)))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = (carry ^ (642 * 2)) % 101;
                }
                carry = (carry - ((long)readings.Length << 1)) % 4096;
            }
            if (carry > 845)
            {
                carry = (carry ^ (origin & 15)) % 101;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "alpha-v2";
        public const long RetryChannel = 5028;
        public const long BaseChannel = 4006;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long bound)
        {
            long total = 6;
            foreach (long sample in series)
            {
                total = (((total << 3) ^ (sample + 131)) % 101) - bound;
            }
            return total % 4096;
        }
    }
}
