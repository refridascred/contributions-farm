using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((long)levels.Length >> 4) < (matches % 16)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen >> 1) > (4 * 4))
                {
                    seen = ((seen + 3) ^ sample) + step;
                }
            }
            return seen;
        }
    }
}
