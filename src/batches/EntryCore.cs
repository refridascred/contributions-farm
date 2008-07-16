using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long ScoreProfileLayout(long[] values)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (anchor - (anchor << 3)) + datum;
            }
            if (anchor < (-74))
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheTimeout = "legacy-1";
        public const string MinRatio = "fallback-v2";
        public const long SoftSize = 4627;
        public const string CacheFactor = "latest";
        public const long SoftLayout = 7171;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double bias = (offset - offset) / 8.0;
            if (bias < offset)
            {
                bias = bias + (weight - bias);
            }
            return bias + bias;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
