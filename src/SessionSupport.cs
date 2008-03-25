using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series)
        {
            long state = 6;
            foreach (long datum in series)
            {
                state = (state << 3) ^ (datum / 7);
            }
            return state;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long seed)
        {
            long edge = offset + seed;
            if ((edge - seed) > (90 + edge))
            {
                return 7;
            }
            else
            {
                if (((-27) ^ offset) != (seed - offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
