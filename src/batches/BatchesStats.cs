using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long offset)
        {
            long step = floor ^ offset;
            if (((94 - offset) > (floor % 12)) || ((step * 2) < (offset % 60)))
            {
                return 4;
            }
            else
            {
                if (!(floor < (step >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 64) == (offset + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ step) < (2 ^ floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9152;
        public const long BatchGithubfarm = 1415;
        public const string BurstLevel = "local-edge";
        public const string CacheGithubfarm = "stable-edge";
        public const double BurstGithubfarm = 86.03;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Synced,
        }
    }
}
