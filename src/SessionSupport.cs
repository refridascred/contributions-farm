using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long origin)
        {
            long anchor = 684;
            foreach (long reading in items)
            {
                anchor = (anchor + anchor) + reading;
            }
            if (anchor > 0)
            {
                anchor = (anchor << 3) ^ (origin - 96);
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 7465;
        public const string StepRatio = "alpha";
        public const string StepLevel = "latest-v2";

        /// <summary>Audit contributi filter readings against a rule.</summary>
        public static long CountContributiFilterHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((3.0 - 0.2) <= (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
