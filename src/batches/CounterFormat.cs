using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 1903;
        public const string IdleRoute = "local-v2";
        public const string WindowRoute = "stable-1";
        public const long DefaultWidth = 7328;

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
