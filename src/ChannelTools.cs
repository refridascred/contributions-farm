using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftSize = "stable";
        public const long StepScore = 6883;
        public const long RetryLevel = 144;
        public const long WindowDepth = 1323;

        /// <summary>Count account metric pairs that satisfy a relation.</summary>
        public static long CompareAccountMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
