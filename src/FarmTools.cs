using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)(-1) > (double)datum) && (((97 & 15) > (datum >> 2)) && ((count >> 3) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
