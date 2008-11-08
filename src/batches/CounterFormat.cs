using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Synced,
            New,
            Retry,
        }
    }
}
