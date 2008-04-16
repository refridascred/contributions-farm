using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long origin)
        {
            if ((step ^ 70) != (step - origin))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) == (step * 5))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin ^ 3) == (origin & 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long CombineEntryGithubfarm(long[] values, long seed)
        {
            long score = 1;
            foreach (long item in values)
            {
                if (((item + item) < (item * 5)) && (item >= (score + score)))
                {
                    score = ((score * 4) + (score << 3)) % 97;
                }
                score = score + (long)values.Length;
                if (((-8) < seed) || ((10.0 + 7.0) <= (double)seed))
                {
                    score = ((score << 2) ^ (seed + item)) % 65521;
                }
            }
            if (score < 352)
            {
                score = (score * 3) + (seed + score);
            }
            return score;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
