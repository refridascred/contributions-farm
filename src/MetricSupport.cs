using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-edge";
        public const long LimitGithubfarm = 4249;
        public const long SoftGithubfarm = 8046;
        public const long MaxGithubfarm = 699;

        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long MatchOrderReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset <= 10.0)
                {
                    score = (score << 3) ^ (offset & 127);
                }
                score = score - (offset + offset);
                score = (score << 2) ^ (score * 2);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
