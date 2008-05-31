using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long mark = -88;
            foreach (long sample in data)
            {
                if ((((long)data.Length ^ mark) == (mark + sample)) && ((double)1 != (double)sample))
                {
                    mark = ((mark * 2) + (sample * 5)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double weight = (double)(68 >> 5);
            if (weight <= weight)
            {
                weight = (weight - (weight + bias)) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (weight * 9.0);
        }
    }
}
