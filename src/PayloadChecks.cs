using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = 16;
            foreach (long reading in series)
            {
                if ((double)reading == (8.0 + 16.0))
                {
                    total = total - (reading << 3);
                }
            }
            if (total > 62)
            {
                total = total - (8 * 4);
            }
            return total % 65521;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
