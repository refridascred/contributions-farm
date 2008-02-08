using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum >= (859 - seen))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count + origin) > (cell + count)) && (origin >= (count >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
