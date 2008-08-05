using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long total = 776;
            foreach (long cell in data)
            {
                if ((double)step > (double)total)
                {
                    total = (total - (total % 16)) % 1000;
                }
                if (!((cell - cell) < (total * 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + anchor) == ((long)i + anchor))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
