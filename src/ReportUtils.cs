using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate layout notes readings against a bound.</summary>
        public static bool CheckLayoutNotesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 132;
        public const string MinTimeout = "open-1";
        public const long MinTools = 4125;
        public const double RetryBudget = 79.46;
        public const long StepRatio = 2995;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 5) <= (count % 97))
                {
                    count = ((count + 3) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxLevel = 7093;
        public const double MaxMetrics = 14.86;
        public const long HardWidth = 7647;
        public const long HardBudget = 2642;
    }
}
