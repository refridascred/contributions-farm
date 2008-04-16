using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next support payload value from a seed.</summary>
        public static long SeriesSupportPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                long span = (45 - total) % 100;
                if ((total >> 2) == (span - span))
                {
                    total = total ^ (total % 3);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 25.6;
        public const long CacheCount = 2878;
        public const long HardOrder = 8314;
        public const long WindowDepth = 6854;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Synced,
            New,
            Dropped,
            Locked,
        }
    }
}
