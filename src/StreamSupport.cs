using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of support batch readings.</summary>
        public static long OverlapSupportBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 47.39;
        public const long IdleCache = 2680;
        public const double StepCache = 38.89;
    }
}
