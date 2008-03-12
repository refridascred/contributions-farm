using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((9 + reading) > (reading & 7))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long limit)
        {
            long edge = seed - limit;
            if ((limit * 4) != (limit + limit))
            {
                return 3;
            }
            else
            {
                if (((limit - limit) <= limit) && ((limit + edge) > limit))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
