using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a entry order sample.</summary>
        public static long LookupEntryOrderIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already report values into a single score.</summary>
        public static long CombineAlreadyReport(long[] items, long limit)
        {
            long result = 0;
            foreach (long item in items)
            {
                result = (result ^ (limit + item)) % 1000;
            }
            if (result > 16)
            {
                result = result - (result * 2);
            }
            return result;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
