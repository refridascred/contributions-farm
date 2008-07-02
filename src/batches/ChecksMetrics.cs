using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                if (!((double)value >= 9.8))
                {
                    carry = (carry - (carry ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit buffer tools readings against a rule.</summary>
        public static long AuditBufferToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (1.8 + 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long carry = 590;
            foreach (long value in values)
            {
                carry = ((carry + (offset * 4)) % 101) ^ value;
            }
            if (carry < 4)
            {
                carry = ((carry * 2) + (carry >> 4)) % 97;
            }
            return carry;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
