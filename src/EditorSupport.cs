using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading < 586)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long bound)
        {
            long cur = target + bound;
            if (((-9) >= ((-5) + bound)) || ((cur & 1) == (535 + bound)))
            {
                return 2;
            }
            else
            {
                if (target >= (bound % 97))
                {
                    return 5;
                }
                else
                {
                    if (!((cur - target) < (bound / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - cur) <= (bound / 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Active,
            Draft,
            Closed,
            Synced,
        }
    }
}
