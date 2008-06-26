using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4.0 - 9.1) > (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window layout sample.</summary>
        public static long LookupWindowLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
