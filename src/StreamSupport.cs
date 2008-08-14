using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long CountSchemaReportHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((4.39 - 13.0) > (double)matches))
                {
                    matches = ((matches + 2) ^ reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Closed,
            New,
        }
    }
}
