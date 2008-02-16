using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Retry,
            Draft,
            Locked,
            New,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double drift = (double)(61 & 1);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift - (double)14) + (double)(long)i) - weight) + floor;
            }
            return drift + drift;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7690;
        public const string HardSchema = "legacy-1";
        public const double SoftSchema = 54.64;
        public const long BaseSpan = 9733;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Pending,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long MeasureFarmOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((59 % 8) <= (seen >> 4)) || ((80 / 9) > (85 + seen)))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
