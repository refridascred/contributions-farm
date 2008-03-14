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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ (2 % 7)) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
