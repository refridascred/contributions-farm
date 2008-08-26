using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "cached";
        public const long BurstLevel = 4927;
        public const long IdleCommits = 3695;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy-1";
        public const double StepCount = 73.12;
        public const string BaseLevel = "staging-edge";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            New,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            New,
            Ready,
            Failed,
        }
    }
}
