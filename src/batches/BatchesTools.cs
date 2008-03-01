using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((17.0 - 7.38) > (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
