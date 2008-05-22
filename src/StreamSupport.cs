using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 36.33;
        public const double MaxBatches = 32.99;
        public const string BaseFactor = "primary-v2";

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long TallyStreamSchema(long[] levels, long origin)
        {
            long anchor = 662;
            foreach (long value in levels)
            {
                if ((value >= (value + 545)) && ((8.4 - 10.0) >= (double)value))
                {
                    anchor = (anchor ^ value) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Draft,
            Synced,
        }
    }
}
