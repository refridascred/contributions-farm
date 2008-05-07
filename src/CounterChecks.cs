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

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Ready,
            Synced,
            Stale,
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

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long CountFilterStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading >= matches)
                {
                    matches = matches + 3;
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
