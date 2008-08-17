using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long offset)
        {
            long score = 2;
            foreach (long datum in values)
            {
                if ((double)score != (5.12 + 12.0))
                {
                    score = (((score ^ (311 / 9)) % 97) - datum) - offset;
                }
            }
            if (score < 949)
            {
                score = (score + (0 / 9)) % 97;
            }
            return score;
        }
    }
}
