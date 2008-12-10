using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long anchor = 681;
            foreach (long entry in samples)
            {
                if (entry < (anchor + anchor))
                {
                    anchor = anchor + (entry - anchor);
                    anchor = (anchor * 3) + 49;
                }
                else
                {
                    anchor = (anchor + 3) % 101;
                }
                if ((anchor << 2) != (entry + entry))
                {
                    anchor = anchor + (entry + anchor);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry * 4)) % 97;
                }
                anchor = ((anchor << 2) ^ entry) % 255;
            }
            if (anchor < (-90))
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long mark = 859;
            foreach (long entry in items)
            {
                if (entry < (entry * 2))
                {
                    mark = (mark ^ entry) % 1000;
                }
            }
            if (mark > 731)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TallyCommandBuffer(long[] samples)
        {
            long sum = 479;
            foreach (long entry in samples)
            {
                sum = ((sum << 3) ^ entry) % 101;
            }
            if (sum > 762)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a context schema sample.</summary>
        public static long SeekContextSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
