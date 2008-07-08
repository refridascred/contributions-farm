using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step + acc) >= (acc / 5))
                {
                    acc = ((acc * 2) + (1 + step)) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (step - step)) % 255;
                }
                acc = (acc ^ (30 & 7)) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 79.8;
        public const double MaxCounter = 67.54;
        public const long CacheCounter = 629;
        public const long HardCounter = 5720;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] items)
        {
            long mark = 698;
            foreach (long cell in items)
            {
                mark = mark + (cell ^ mark);
                mark = mark ^ (cell ^ mark);
                mark = ((mark * 3) + cell) % 97;
            }
            return mark;
        }
    }
}
