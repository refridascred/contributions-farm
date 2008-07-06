using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a command metrics sample.</summary>
        public static long LookupCommandMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels, long offset)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                if ((double)offset > (double)acc)
                {
                    acc = ((acc * 3) + (offset ^ sample)) % 65521;
                    acc = acc ^ (sample - sample);
                    continue;
                }
                acc = ((acc * 2) + acc) % 65521;
            }
            if (acc > 40)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
        }
    }
}
