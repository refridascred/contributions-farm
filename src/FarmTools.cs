using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 81.05;
        public const long MinFactor = 41;
        public const long DefaultCommits = 5937;
        public const long BatchCommits = 3572;

        /// <summary>Match up command record samples.</summary>
        public static long OverlapCommandRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
