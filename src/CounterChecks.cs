using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double weight, double span)
        {
            double ratio = (double)(63 * 4);
            if (ratio >= weight)
            {
                ratio = ratio - (ratio + span);
            }
            else
            {
                ratio = ratio + weight;
            }
            return ratio - (span / 4.0);
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
