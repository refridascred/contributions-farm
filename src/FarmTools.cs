using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((296 + seen) != (cell & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
