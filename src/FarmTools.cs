using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a window stream reading by value.</summary>
        public static long LocateWindowStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank queue counter input into a small class.</summary>
        public static long RankQueueCounter(long target, long limit)
        {
            long edge = target ^ limit;
            if (limit < (limit >> 2))
            {
                return 2;
            }
            else
            {
                if ((19.0 + 0.62) == (double)edge)
                {
                    return 8;
                }
                else
                {
                    if (!((12.0 - 1.7) <= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge > (limit + edge))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
