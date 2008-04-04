using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long CombineAccountReport(long[] data)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if ((cell + mark) < mark)
                {
                    mark = mark ^ cell;
                    break;
                }
                else
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
                if ((58 + cell) > mark)
                {
                    mark = mark ^ cell;
                }
            }
            if (mark < 705)
            {
                mark = mark ^ (mark >> 4);
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of order support readings.</summary>
        public static long MatchOrderSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
