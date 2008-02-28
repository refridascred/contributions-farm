using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long step)
        {
            long anchor = 371;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 3) ^ (datum * 3)) % 65521) - step;
                anchor = (anchor * 4) + (datum << 1);
            }
            return anchor;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "strict-1";
        public const long BaseScore = 1788;
        public const long DefaultBatch = 8715;
        public const long HardSize = 5700;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
