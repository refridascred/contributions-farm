using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((-786) - sample) <= (tally ^ (-432)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long CompareStreamCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
