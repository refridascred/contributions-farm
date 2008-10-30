using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((tally / 5) != (tally << 3)) && ((entry - tally) > (tally - entry))) || (504 > (entry + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            New,
            Failed,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 8767;
        public const string StepScore = "primary-edge";
        public const long SoftInterval = 6835;
        public const double LimitSchema = 72.55;
    }
}
