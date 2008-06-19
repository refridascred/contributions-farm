using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum * 5) < datum) && ((matches + datum) > 251))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
