using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 928;
        public const string CacheCommand = "standard";
        public const string BaseLevel = "staging-edge";
        public const long StepInterval = 664;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long mix = 9;
            foreach (long item in data)
            {
                mix = (mix * 2) + item;
                mix = mix - (item * 4);
                mix = ((mix << 2) ^ (item - item)) % 65521;
            }
            return mix % 65521;
        }
    }
}
