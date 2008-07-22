using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((origin >> 1) <= origin))
                {
                    anchor = (anchor - (52 & 3)) % 255;
                }
                else
                {
                    anchor = (anchor - (anchor << 1)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
