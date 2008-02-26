using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix ^ (origin & 1);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
