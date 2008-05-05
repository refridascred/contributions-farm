using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 8585;
        public const string StepChannel = "latest";
        public const long RetryChannel = 910;
        public const long MaxChannel = 394;
        public const long StepTimeout = 6493;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultWidth = "staging";
        public const long DefaultCounter = 4169;
        public const string MaxBudget = "primary-1";
        public const long HardCounter = 8546;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2 + origin) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
