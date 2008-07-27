using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((16.0 + 9.1) > (double)value)
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

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 2611;
        public const double BurstCommand = 92.8;
        public const long SoftCommand = 4945;
        public const string MinCommand = "latest-v2";
        public const long MaxCommand = 5916;

        /// <summary>Find the first report channel entry that matches the target.</summary>
        public static long LookupReportChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream notes pairs that satisfy a relation.</summary>
        public static long OverlapStreamNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
