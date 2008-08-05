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

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((bound * 2) == (item & 255)) || ((278 - tally) <= item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
