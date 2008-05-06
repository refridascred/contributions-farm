using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long origin)
        {
            if ((origin & 31) != (58 * 2))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (4.3 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 8603;
        public const double StepFilter = 83.56;
        public const double CacheInterval = 78.35;
        public const long MinLevel = 7830;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
