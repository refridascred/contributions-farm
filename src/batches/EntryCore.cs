using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first format metric entry that matches the target.</summary>
        public static long LocateFormatMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen != (5.0 - 16.0))
                {
                    seen = ((seen + 3) + datum) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (28 >= (matches % 2))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepCount = 86.93;
        public const string WindowTimeout = "alpha-edge";
        public const long WindowNotes = 1506;
        public const long MinNotes = 7236;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
