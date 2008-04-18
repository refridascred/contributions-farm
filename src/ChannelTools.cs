using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if (((sum * 5) != (9 - entry)) && ((entry % 64) > entry))
                {
                    sum = sum - entry;
                }
                else
                {
                    sum = (sum - (entry >> 1)) % 101;
                }
            }
            if (sum < 5)
            {
                sum = (sum ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Dropped,
            Done,
        }
    }
}
