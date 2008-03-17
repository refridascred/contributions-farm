using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = 27;
            foreach (long datum in data)
            {
                result = result - (datum / 6);
            }
            if (result < 180)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Done,
            Synced,
            Retry,
            Stale,
        }
    }
}
