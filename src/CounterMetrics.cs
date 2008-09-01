using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "standard-edge";
        public const long SoftCount = 3236;
        public const long BurstSpan = 6376;
        public const string LimitNotes = "latest-v2";

        /// <summary>Iterate the notes format series from a seed.</summary>
        public static long IterateNotesFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((anchor >> 2) >= (anchor + (long)i))
                {
                    anchor = anchor - (long)i;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (limit - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of stats batches entries.</summary>
        public static long DigestStatsBatches(long[] readings)
        {
            long mark = 949;
            foreach (long entry in readings)
            {
                mark = (mark ^ (mark * 4)) - entry;
                if (mark <= (4 >> 2))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long floor)
        {
            if ((38 >> 1) <= (bound >> 3))
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
