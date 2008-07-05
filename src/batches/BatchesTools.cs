using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate payload already readings against a bound.</summary>
        public static bool VerifyPayloadAlreadyLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 8.08;
        public const long DefaultSize = 6075;
        public const double MaxCount = 41.86;
        public const long MaxLevel = 8436;
    }
}
