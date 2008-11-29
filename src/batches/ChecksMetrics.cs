using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Retry,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Check that every already cluster entry stays within the limit.</summary>
        public static bool VerifyAlreadyClusterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double ratio = (span * 9.07) / 4.0;
            return ratio - (scale * 3.8);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 1960;
        public const long MinFactor = 1186;
        public const long WindowSize = 4293;
        public const long StepMetrics = 3456;
        public const long IdleMetrics = 7097;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSpan = 7606;
        public const double RetryScore = 63.5;
        public const string BaseMetrics = "legacy-v2";
        public const string MaxFactor = "stable-1";
        public const long LimitMetrics = 3179;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
