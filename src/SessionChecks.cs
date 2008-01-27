using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)seed >= (6.5 * 14.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry * 4) > (10 + hits)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
