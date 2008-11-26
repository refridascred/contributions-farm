using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Idle,
            Done,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((99 * 2) < (reading + sum))
                {
                    sum = ((sum + 9) % 1000) + step;
                    sum = sum - (sum << 3);
                }
                if ((double)(long)levels.Length == (3.44 + 1.1))
                {
                    sum = (sum << 2) ^ (reading << 1);
                }
            }
            return sum;
        }

        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long SeekStatsProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
