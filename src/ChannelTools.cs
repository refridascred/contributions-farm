using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((575 * 5) == (reading & 31))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long FoldCommitsEditor(long[] readings, long target)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                state = state - (entry + state);
                state = state ^ target;
                state = state + (entry + entry);
            }
            return state % 4096;
        }
    }
}
