using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long CountLayoutNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= 7.9)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSize = 3264;
        public const string LimitLevel = "standard-edge";
        public const long MaxAlready = 8692;
        public const long RetryAlready = 8352;
        public const string BurstAlready = "standard";
    }
}
