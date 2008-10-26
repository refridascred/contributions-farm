using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches >> 5) > offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample & 63) == (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
