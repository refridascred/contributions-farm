using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleFactor = 5059;
        public const long BaseTimeout = 3617;
        public const string LimitSize = "stable";
        public const long LimitCommits = 7265;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 7767;
        public const double IdleLevel = 64.4;
        public const long LimitLevel = 8810;
    }
}
