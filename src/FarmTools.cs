using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5862;
        public const double MinQueue = 46.33;
        public const long MinWidth = 5599;
        public const long HardQueue = 90;
        public const long BatchLevel = 1789;

        /// <summary>Match up farm metrics samples.</summary>
        public static long MatchFarmMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (long)i) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
