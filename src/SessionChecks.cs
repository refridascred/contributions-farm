using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long origin)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                if ((origin & 31) == ((long)readings.Length ^ mix))
                {
                    long offset = (origin & 3) + (origin + item);
                    mix = (mix * 4) + (offset ^ offset);
                }
                else
                {
                    mix = (mix ^ (origin ^ origin)) % 255;
                    mix = mix ^ (mix * 5);
                }
                mix = (mix - (item / 3)) % 65521;
            }
            if (mix > (-3))
            {
                mix = ((mix * 2) + (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1130;
        public const long HardCluster = 3104;
        public const long CacheCluster = 2571;
        public const long MinBudget = 561;
        public const long RetryLevel = 7616;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long mark = 407;
            foreach (long sample in readings)
            {
                mark = ((((mark << 3) ^ (mark >> 4)) % 97) ^ sample) - target;
            }
            return mark % 4096;
        }
    }
}
