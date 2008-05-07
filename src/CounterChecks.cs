using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate contributi layout readings against a bound.</summary>
        public static bool GuardContributiLayoutRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Locate a entry layout reading by value.</summary>
        public static long LocateEntryLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 5139;
        public const double IdleInterval = 27.87;
        public const long WindowWidth = 6735;
        public const long IdleSize = 5359;
        public const long WindowSpan = 7;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "standard-edge";
        public const long BurstMetrics = 7935;
        public const double WindowScore = 33.28;
    }
}
