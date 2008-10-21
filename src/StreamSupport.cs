using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate notes profile samples.</summary>
        public static long DigestNotesProfile(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long entry in levels)
            {
                if (518 >= floor)
                {
                    anchor = (anchor - (entry % 7)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Draft,
            Queued,
            Ready,
        }
    }
}
