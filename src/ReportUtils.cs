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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a window graph reading by value.</summary>
        public static long FindWindowGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxLevel = 7093;
        public const double MaxMetrics = 14.86;
        public const long HardWidth = 7647;
        public const long HardBudget = 2642;
    }
}
