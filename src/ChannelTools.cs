using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long CountPayloadBufferOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits > (2.0 / 6.0))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 5) >= 199))
                {
                    tally = ((tally + 1) ^ datum) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
