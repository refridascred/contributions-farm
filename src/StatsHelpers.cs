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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((422 - cell) > (cell - count)) || ((7.4 + 7.9) > (double)cell)) || (10.0 > (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
