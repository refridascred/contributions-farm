using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long TotalCommitsEditor(long[] data)
        {
            long total = 3;
            foreach (long item in data)
            {
                if (total > item)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                if ((item & 15) < (total + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
