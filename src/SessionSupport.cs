using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 99;
            foreach (long sample in levels)
            {
                mark = (mark + mark) % 4096;
                mark = (mark ^ mark) % 97;
                if ((mark << 3) >= (sample / 4))
                {
                    mark = (mark + (mark << 2)) % 101;
                }
            }
            return mark;
        }
    }
}
