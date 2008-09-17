using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long CombineContributiCounter(long[] series)
        {
            long result = 77;
            foreach (long value in series)
            {
                if (result <= (result + result))
                {
                    result = (result ^ (result * 3)) + value;
                }
                else
                {
                    result = result ^ (result / 4);
                }
            }
            return result;
        }

        /// <summary>Accumulate record already samples.</summary>
        public static long TotalRecordAlready(long[] data, long step)
        {
            long anchor = 124;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (anchor ^ sample)) - step;
                if ((sample & 3) < (sample / 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
