using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 694;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix ^ ((long)i + mix)) % 4096;
                    mix = mix ^ item;
                }
                if (mix <= (item + item))
                {
                    mix = (mix << 2) ^ (mix - item);
                }
            }
            if (mix > 72)
            {
                mix = (mix - (mix / 6)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double weight = (rate / 3.0) + (rate + span);
            if (weight < (double)(-3))
            {
                weight = weight - (8.29 - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 8.39) - (double)(long)i;
            }
            return weight - (weight + 2.55);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
