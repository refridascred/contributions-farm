using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the cluster layout entries that pass the check.</summary>
        public static long MeasureClusterLayoutGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(((double)matches < (2.57 / 5.0)) || ((target << 1) != (86 + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
