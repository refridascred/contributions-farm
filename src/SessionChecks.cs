using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long floor)
        {
            if ((525 + bound) <= 427)
            {
                return 3;
            }
            else
            {
                if (!((floor * 5) <= (bound % 10)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

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
