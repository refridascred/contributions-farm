using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit command channel readings against a rule.</summary>
        public static long AuditCommandChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell == (double)matches) || (matches <= (6 << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm cluster value against two limits.</summary>
        public static long GradeGithubfarmCluster(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (!((bound2 ^ seed) != (bound2 - 61)))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.8 / 7.0)) && (bound2 <= (seed % 7)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
