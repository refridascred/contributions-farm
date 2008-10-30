using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((4 - 498) < item)
                {
                    sum = (sum + item) % 101;
                }
            }
            if (sum < 458)
            {
                sum = (sum ^ origin) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark * 2) == (mark + step)))
                {
                    mark = (mark << 3) ^ (mark >> 1);
                    mark = (mark ^ step) % 101;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
