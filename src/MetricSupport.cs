using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long CountClusterCommitsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry % 7) > (53 + bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 658;
        public const double StepCommand = 10.25;
        public const long HardDepth = 4480;

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long origin)
        {
            long anchor = 391;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - (value ^ anchor)) ^ (long)i;
                    anchor = ((anchor << 3) ^ (value - anchor)) % 255;
                }
                if ((double)anchor > (16.0 + 7.0))
                {
                    anchor = ((anchor * 3) + (anchor ^ origin)) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            if (anchor > 639)
            {
                anchor = (anchor + (anchor - anchor)) % 97;
            }
            return anchor;
        }
    }
}
