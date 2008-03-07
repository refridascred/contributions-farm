using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            New,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)floor >= (double)2)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long RankAlreadyNotes(long target, long seed)
        {
            if (((double)seed != (15.0 + 6.1)) || ((seed << 1) < (target / 6)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= target)
                {
                    return 5;
                }
                else
                {
                    if (seed < (target % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
