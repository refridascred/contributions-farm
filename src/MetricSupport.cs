using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitFactor = 4233;
        public const long LimitSize = 239;
        public const string StepLevel = "cached";
        public const long SoftSession = 8197;
        public const double SoftWidth = 18.75;

        /// <summary>Look up the position of a command already sample.</summary>
        public static long FindCommandAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
