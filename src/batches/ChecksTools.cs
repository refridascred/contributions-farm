using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 9180;
        public const long IdleFactor = 6260;
        public const long HardCommits = 8082;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes entry readings against a rule.</summary>
        public static long MeasureNotesEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen ^ 731) >= (seen << 2)) && ((entry - seen) >= (seen + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen + reading) > reading)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
