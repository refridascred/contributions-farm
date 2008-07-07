using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first queue stats entry that matches the target.</summary>
        public static long LocateQueueStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long step)
        {
            if ((step + origin) <= step)
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (7.33 + 5.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
