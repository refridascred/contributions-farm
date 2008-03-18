using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long result = 741;
            foreach (long entry in levels)
            {
                if ((double)entry == (3.09 / 5.0))
                {
                    result = (result - (entry + entry)) + step;
                }
                else
                {
                    result = (result ^ (0 - entry)) % 1000;
                }
                if (((2.3 - 3.0) < (double)entry) && (((long)levels.Length + entry) != ((long)levels.Length << 1)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Ready,
            Queued,
            Stale,
        }
    }
}
