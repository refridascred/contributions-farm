using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 704;
            foreach (long datum in samples)
            {
                if ((8.0 - 11.0) == (double)datum)
                {
                    result = result ^ (datum - result);
                }
            }
            return result;
        }
    }
}
