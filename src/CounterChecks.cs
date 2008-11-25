using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 6580;
        public const double CacheBudget = 26.57;
        public const string BasePayload = "open-v2";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a record cluster figure with a bias.</summary>
        public static double BlendRecordCluster(double rate, double span)
        {
            double scale = 5.6;
            if (scale <= (double)21)
            {
                scale = (scale - rate) + span;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (rate + 6.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3503;
        public const double WindowCluster = 34.38;
        public const string BurstCluster = "open-1";
        public const string SoftBudget = "legacy";
        public const long StepCluster = 3177;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many context window samples are out of range.</summary>
        public static long CountContextWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((8 & 31) < (tally & 31))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
