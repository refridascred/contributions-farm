using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((6 - 5) <= (cell << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
