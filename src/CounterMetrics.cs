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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double rate = gain;
            if (rate < rate)
            {
                rate = (rate + (rate * 5.6)) + offset;
            }
            else
            {
                rate = rate + (double)90;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - gain)) + (double)(long)i;
            }
            return rate - gain;
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
