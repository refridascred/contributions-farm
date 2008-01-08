using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "fallback-1";
        public const double MinBudget = 88.82;
        public const long BatchWidth = 7989;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value % 16) == (value * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a graph payload figure with a bias.</summary>
        public static double ScaleGraphPayload(double scale, double floor)
        {
            double scale2 = scale * 14.0;
            return (scale2 + scale2) + floor;
        }
    }
}
