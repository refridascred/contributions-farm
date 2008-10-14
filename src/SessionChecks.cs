using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 1963;
        public const long BurstTimeout = 8055;
        public const double WindowWidth = 21.39;
        public const long BurstReport = 5943;
        public const long MinReport = 6038;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)target)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Queued,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples, long step)
        {
            long anchor = 62;
            foreach (long item in samples)
            {
                if (!((anchor >= (anchor + item)) || ((anchor % 5) <= (anchor & 31))))
                {
                    anchor = (anchor << 2) ^ 451;
                }
                if (!(step >= (step << 3)))
                {
                    anchor = (anchor + (item ^ anchor)) % 1000;
                }
            }
            return anchor;
        }
    }
}
