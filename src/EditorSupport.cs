using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinLevel = "open-1";
        public const long DefaultWindow = 2717;
        public const string BatchWindow = "cached";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5454;
        public const string MinStream = "open";
        public const double LimitTimeout = 61.29;
        public const long MaxSpan = 9217;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) < ((long)i & 15)))
                {
                    result = result + ((long)i + (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
