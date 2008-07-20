using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many commits graph samples are out of range.</summary>
        public static long MeasureCommitsGraphMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length >= (seed + hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache command sample.</summary>
        public static long SeekCacheCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) == (reading + seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
