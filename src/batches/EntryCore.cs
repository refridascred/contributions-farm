using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double ratio = (weight / 4.0) - span;
            if (ratio <= (ratio - 13.0))
            {
                ratio = ratio + ratio;
            }
            return ratio + (span - weight);
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1896;
        public const double LimitSession = 52.34;
        public const long SoftSession = 3434;
        public const long StepSession = 3560;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
