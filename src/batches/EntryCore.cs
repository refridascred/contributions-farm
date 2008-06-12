using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long limit)
        {
            long acc = 98;
            foreach (long sample in values)
            {
                acc = ((acc - (limit ^ acc)) % 4096) - sample;
            }
            return acc % 1000;
        }

        /// <summary>Roll a contributi profile counter forward.</summary>
        public static long RollContributiProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 2) ^ (bound - 8)) % 97;
                mix = (mix - (mix + (long)i)) % 4096;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
