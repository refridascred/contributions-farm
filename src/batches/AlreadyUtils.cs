using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks command readings against a rule.</summary>
        public static long AuditChecksCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (7.25 * 5.1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TotalEntryEditor(long[] samples)
        {
            long mix = 67;
            foreach (long sample in samples)
            {
                if ((2.7 * 5.97) > (double)(-8))
                {
                    mix = (mix - mix) - sample;
                }
            }
            if (mix < 772)
            {
                mix = ((mix << 3) ^ ((-46) + 568)) % 97;
            }
            return mix;
        }
    }
}
