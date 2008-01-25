using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ seed) - value;
            }
            if (mix < 239)
            {
                mix = (mix << 2) ^ ((long)data.Length - mix);
            }
            return mix;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Retry,
            Locked,
            Active,
            Closed,
        }
    }
}
