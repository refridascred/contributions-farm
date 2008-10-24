using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double ratio, double span)
        {
            double rate = 4.19;
            if (rate <= (ratio - rate))
            {
                rate = (rate - 8.97) - span;
            }
            return rate + (0.71 * 8.0);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Dropped,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up profile contributi samples.</summary>
        public static long MatchProfileContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            New,
            Failed,
            Retry,
            Pending,
        }
    }
}
