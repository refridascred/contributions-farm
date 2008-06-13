using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Draft,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Audit token queue readings against a rule.</summary>
        public static long MeasureTokenQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > (reading ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long offset)
        {
            long score = 64;
            foreach (long item in series)
            {
                if (((offset + 441) > (score ^ 453)) && ((item + (-760)) != (3 % 60)))
                {
                    score = score + (item / 9);
                }
                else
                {
                    score = score - (offset + 237);
                }
            }
            return score;
        }
    }
}
