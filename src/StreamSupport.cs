using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Owner { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next filter queue value from a seed.</summary>
        public static long RollFilterQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
