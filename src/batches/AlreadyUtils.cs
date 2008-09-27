using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels)
        {
            long carry = 500;
            foreach (long sample in levels)
            {
                if ((double)carry <= (8.0 * 3.58))
                {
                    carry = ((carry + carry) % 101) + sample;
                }
            }
            return carry;
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Locked,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 52;
            foreach (long sample in data)
            {
                acc = ((acc ^ acc) % 101) ^ sample;
            }
            if (acc > (-657))
            {
                acc = (acc - ((-80) * 4)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
