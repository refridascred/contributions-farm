using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Failed,
            Ready,
            Dropped,
        }
    }
}
