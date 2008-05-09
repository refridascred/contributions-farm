using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinRatio = "local-edge";
        public const long BaseSize = 4172;
        public const string BatchBudget = "alpha-v2";

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 285;
        public const long StepToken = 7036;
        public const double SoftDepth = 68.32;
    }
}
