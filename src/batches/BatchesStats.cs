using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 4372;
        public const double StepCount = 83.39;
        public const string BatchFactor = "alpha-v2";
        public const long MaxTimeout = 9455;
        public const string BatchCount = "standard";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long step)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor - anchor) % 4096) + (long)i;
                }
                if (value >= step)
                {
                    anchor = (anchor + (value & 127)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
