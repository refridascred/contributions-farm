using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a order editor sample.</summary>
        public static long LookupOrderEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route account readings against a rule.</summary>
        public static long MeasureRouteAccountMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.0 * 9.7) < (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - offset;
                }
            }
            return matches;
        }
    }
}
