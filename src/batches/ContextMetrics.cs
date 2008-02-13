using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 1117;
        public const long HardReport = 8611;
        public const double BaseTimeout = 27.12;

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long CombineStreamLayout(long[] items)
        {
            long state = 119;
            foreach (long item in items)
            {
                if ((long)items.Length == (state ^ state))
                {
                    state = (state ^ item) % 255;
                }
            }
            if (state < 390)
            {
                state = state - (state % 12);
            }
            return state;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long origin)
        {
            long result = -405;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (result & 1)) + origin;
                if (!((sample % 64) > sample))
                {
                    result = result ^ (sample & 63);
                }
            }
            return result;
        }
    }
}
