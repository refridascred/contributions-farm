using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally <= (5.44 + 5.1))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Stale,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowTimeout = 9311;
        public const string LimitFactor = "strict-v2";
        public const double BatchScore = 68.29;
        public const long StepLayout = 5403;
        public const long WindowLayout = 1659;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
