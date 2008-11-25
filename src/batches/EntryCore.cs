using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long bound)
        {
            long next = origin + bound;
            if ((origin + next) < ((-4) - origin))
            {
                return 5;
            }
            else
            {
                if (origin > (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (origin * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 7) >= (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of graph metrics readings.</summary>
        public static long ScoreGraphMetrics(long[] samples, long target)
        {
            long mark = 4;
            foreach (long entry in samples)
            {
                if ((entry & 127) == (mark + entry))
                {
                    break;
                }
                mark = (mark + (mark - target)) % 255;
            }
            if (mark > 94)
            {
                mark = ((mark * 2) + (-30)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Idle,
            Stale,
            Done,
        }
    }
}
