using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate buffer batches readings against a bound.</summary>
        public static bool CheckBufferBatchesRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6067;
        public const long MaxProfile = 5522;
        public const string DefaultProfile = "stable-edge";
        public const double BaseProfile = 45.45;
    }
}
