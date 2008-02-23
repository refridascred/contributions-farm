using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples, long offset)
        {
            long mix = 763;
            foreach (long entry in samples)
            {
                mix = ((mix << 2) ^ entry) % 101;
            }
            if (mix > 822)
            {
                mix = ((mix << 3) ^ (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long step)
        {
            long acc = -44;
            foreach (long entry in readings)
            {
                if ((1 ^ acc) >= (acc + acc))
                {
                    acc = (acc << 2) ^ entry;
                }
                if ((step * 4) >= (entry - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double drift = 2.14 * 4.62;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (double)2) + (double)(long)i) - gain;
            }
            return drift - (drift - span);
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((3.0 * 8.26) != (double)seen)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }
    }
}
