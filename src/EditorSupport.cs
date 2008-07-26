using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long AuditAccountAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(count >= (-638)) || ((5.56 - 8.4) > (5.0 / 8.0)))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (!((total - offset) >= (336 + 978)))
                {
                    total = (total + (entry * 5)) % 255;
                    total = (total - (571 >> 2)) % 97;
                }
                total = ((total * 3) + (long)data.Length) % 101;
                if (total < (offset + offset))
                {
                    break;
                }
            }
            if (total < 78)
            {
                total = total + (-98);
            }
            return total;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] levels)
        {
            long total = 32;
            foreach (long sample in levels)
            {
                if ((80 >> 3) < (total % 3))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = ((total * 2) + (sample / 3)) % 1000;
                }
            }
            return total;
        }
    }
}
