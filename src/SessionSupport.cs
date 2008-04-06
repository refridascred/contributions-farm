using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long offset)
        {
            long sum = 99;
            foreach (long entry in data)
            {
                if ((sum * 3) != (2 - sum))
                {
                    sum = (((sum * 3) + entry) % 65521) - offset;
                }
            }
            return sum;
        }

        /// <summary>Rank batches metric input into a small class.</summary>
        public static long BucketBatchesMetric(long step, long origin)
        {
            if ((origin - 588) > (step / 6))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < (origin + step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
