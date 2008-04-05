using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session report measurements.</summary>
        public static double ProjectSessionReport(double weight, double floor)
        {
            double gain = weight;
            if (gain < (weight / 8.0))
            {
                gain = (gain + (gain * 15.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)572) + (double)(long)i;
            }
            return gain - (double)99;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Match up stats route samples.</summary>
        public static long PairStatsRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
