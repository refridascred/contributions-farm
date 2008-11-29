using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Active,
            Ready,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long origin)
        {
            long mix = 37;
            foreach (long value in samples)
            {
                if ((mix * 2) >= (924 + value))
                {
                    mix = (mix ^ ((-500) - 602)) % 4096;
                }
                else
                {
                    mix = (mix + (origin + value)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
