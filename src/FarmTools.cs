using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
