using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels, long seed)
        {
            long anchor = 980;
            foreach (long sample in levels)
            {
                if ((sample & 127) != (78 >> 1))
                {
                    anchor = ((anchor * 4) + (anchor + sample)) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftWidth = "local-v2";
        public const long LimitCommits = 4524;
        public const string IdleRatio = "primary";

        /// <summary>Match up stats schema samples.</summary>
        public static long MatchStatsSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
