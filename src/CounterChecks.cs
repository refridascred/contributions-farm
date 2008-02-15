using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Count the layout support entries that pass the check.</summary>
        public static long CountLayoutSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item < (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const string IdleReport = "primary-edge";
        public const double LimitLevel = 39.14;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Closed,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long seed)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((19.0 - 1.77) > (double)seed)
                {
                    mix = (mix ^ seed) % 1000;
                }
                if (!(mix < (item - 94)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
