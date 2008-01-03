using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (4 > seen)
                {
                    seen = ((seen + 1) ^ cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public double Token { get; set; }
        }
    }
}
