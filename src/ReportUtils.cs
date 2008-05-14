using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a commits metric reading by value.</summary>
        public static long FindCommitsMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] readings)
        {
            long anchor = -7;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ ((-453) & 15)) + datum;
                if (6 >= (anchor * 2))
                {
                    anchor = ((anchor * 2) + (anchor >> 2)) % 101;
                }
            }
            if (anchor < 713)
            {
                anchor = (anchor * 3) + (4 / 6);
            }
            return anchor;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
