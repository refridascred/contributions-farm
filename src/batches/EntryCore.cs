using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits >> 2) < hits) || (3.02 < (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-edge";
        public const long BatchReport = 502;
        public const long WindowCount = 8118;
        public const long HardReport = 3550;
        public const string SoftReport = "local-v2";

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((634 - tally) >= step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long FindChannelMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
