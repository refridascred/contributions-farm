using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstInterval = 81.86;
        public const long BatchLevel = 3370;
        public const long DefaultMetric = 1452;
        public const string StepMetric = "latest";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((double)count == (9.52 + 4.0)) && ((reading + reading) < 2)) || (count <= (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long SeekCommandRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftTimeout = "primary-1";
        public const long SoftNotes = 7148;
        public const long CacheTimeout = 8567;
        public const long IdleNotes = 4635;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
        }
    }
}
