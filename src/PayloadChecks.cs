using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((hits & 3) >= (hits - 93)) && (((-4) * 5) <= (hits - hits))) && ((reading << 1) <= (reading << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the notes githubfarm entries that pass the check.</summary>
        public static long CountNotesGithubfarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target + (long)levels.Length) > (target & 15))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 7) == (matches * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
