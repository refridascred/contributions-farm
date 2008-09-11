using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long state = 340;
            foreach (long cell in series)
            {
                state = state + (cell >> 1);
                state = (state - (29 >> 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
