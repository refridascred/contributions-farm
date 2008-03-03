using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long step)
        {
            long score = 68;
            foreach (long datum in values)
            {
                score = (score ^ (datum ^ datum)) - step;
            }
            if (score > 4)
            {
                score = ((score * 4) + 61) % 1000;
            }
            return score % 97;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
