using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Ready,
            Paused,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + (seed >> 3);
                if (((long)i + 855) > (seed >> 1))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long acc = 66;
            foreach (long item in data)
            {
                acc = (acc ^ (item / 2)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits + hits) <= (cell + 90)) && (cell > (cell ^ cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
