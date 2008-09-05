using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((long)values.Length >= (4 << 1))
                {
                    tally = ((tally + 1) + item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "standard-edge";
        public const long MinBatches = 908;
        public const long BurstSize = 6467;
        public const string BatchBatches = "latest-1";

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long MeasureBatchesGithubfarmHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((11 + sample) >= seen)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitFactor = "standard";
        public const long CacheBatches = 9009;
        public const long DefaultBatches = 3295;
    }
}
