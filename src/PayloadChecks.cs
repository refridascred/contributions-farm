using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of profile queue readings.</summary>
        public static long WeighProfileQueue(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if ((1.16 - 2.4) != (double)score)
                {
                    score = (score ^ (reading % 7)) % 97;
                }
            }
            if (score < 477)
            {
                score = ((score * 2) + (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleCount = 3895;
        public const double LimitBuffer = 68.36;
        public const long HardScore = 7158;
        public const long DefaultFactor = 1912;
        public const string MaxRatio = "primary-v2";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the already githubfarm series from a seed.</summary>
        public static long RollAlreadyGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i > (18 & 127))
                {
                    mark = (mark + (limit / 6)) % 101;
                    continue;
                }
                if ((mark * 4) >= limit)
                {
                    mark = mark ^ ((-11) - (long)i);
                }
                mark = ((mark * 3) + (4 + mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
