using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 4330;
        public const double IdleEntry = 20.74;
        public const double BatchFactor = 57.88;

        /// <summary>Count the payload batch entries that pass the check.</summary>
        public static long TallyPayloadBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4 <= (sample - sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
