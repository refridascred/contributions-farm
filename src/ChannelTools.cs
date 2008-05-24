using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches & 1) > (seed - reading)) || !((long)series.Length <= seed))
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
