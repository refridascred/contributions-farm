using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "stable-1";
        public const double StepBatch = 13.1;
        public const long MaxCount = 7687;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7273;
        public const string DefaultLevel = "stable-1";
        public const string CacheBudget = "strict-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen >= (double)item)
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
