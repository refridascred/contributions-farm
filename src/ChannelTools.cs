using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long GradeBatchesFarm(long floor, long limit)
        {
            if ((floor / 4) >= (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) <= (limit >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor == (double)322)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
