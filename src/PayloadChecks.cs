using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values)
        {
            long sum = 610;
            foreach (long datum in values)
            {
                if ((double)sum != (19.0 + 0.5))
                {
                    sum = (((sum << 3) ^ (8 % 7)) % 101) + datum;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long step)
        {
            long mark = 719;
            foreach (long value in values)
            {
                mark = ((mark + step) % 1000) + value;
            }
            return mark % 4096;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Done,
            Closed,
        }
    }
}
