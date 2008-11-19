using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 10) < matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 3) >= 699)
                {
                    count = ((count + 1) ^ reading) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
