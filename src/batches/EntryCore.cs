using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 202;
        public const long HardRoute = 1438;
        public const long LimitScore = 638;
        public const long IdleCount = 950;
        public const long IdleDepth = 6350;

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = (state + (limit + limit)) % 1000;
                state = (state * 4) + ((long)i - (long)i);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 938;
        public const long StepLevel = 3741;
        public const string CacheGithubfarm = "fallback-1";
        public const long BurstInterval = 504;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
