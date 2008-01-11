using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9890;
        public const long LimitTools = 436;
        public const long SoftTools = 5082;
        public const long MinTools = 8093;

        /// <summary>Rank payload metrics input into a small class.</summary>
        public static long BucketPayloadMetrics(long limit, long step)
        {
            long bound = limit ^ step;
            if ((limit > 15) || ((limit - step) >= (bound >> 3)))
            {
                return 5;
            }
            else
            {
                if ((step + limit) >= (143 - 41))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score * 5) + (score + score);
                score = ((score << 3) ^ (long)i) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
