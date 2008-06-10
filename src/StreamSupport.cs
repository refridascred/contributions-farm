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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((12.0 * 18.0) >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
