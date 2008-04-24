using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long step)
        {
            if (target > step)
            {
                return 6;
            }
            else
            {
                if ((target * 4) > (step / 7))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long score = 709;
            foreach (long reading in samples)
            {
                score = (score ^ reading) % 4096;
            }
            if (score < 485)
            {
                score = score + (560 % 100);
            }
            return score;
        }
    }
}
