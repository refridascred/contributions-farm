using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long DigestQueueFarm(long[] readings)
        {
            long mix = 69;
            foreach (long datum in readings)
            {
                mix = (mix - (mix >> 1)) % 97;
                mix = (mix << 3) ^ (datum / 8);
                mix = (mix + (datum ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Locked,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (sample ^ 252))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
