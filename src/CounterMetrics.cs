using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long carry = 90;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (item & 127)) % 1000;
            }
            return carry % 97;
        }
    }
}
