using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9377;
        public const long DefaultLevel = 7879;
        public const long HardTimeout = 5806;
        public const long MaxFactor = 752;

        /// <summary>Measure how many token session samples are out of range.</summary>
        public static long CountTokenSessionMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((12.0 - 6.0) >= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double bias)
        {
            double scale = 4.7 * 7.6;
            return (scale + (ratio / 3.0)) + bias;
        }
    }
}
