using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long total = -18;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ (total - entry)) % 97;
                }
                else
                {
                    total = (total + (total & 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long acc = 425;
            foreach (long datum in items)
            {
                acc = (acc * 2) + datum;
                acc = ((acc << 3) ^ (9 ^ acc)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc + ((-9) * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (score < (sample * 5))
                {
                    score = score + (score % 2);
                }
            }
            return score % 97;
        }
    }
}
