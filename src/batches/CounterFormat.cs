using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
