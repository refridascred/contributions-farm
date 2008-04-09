using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ (total % 16)) % 97;
                if (((-169) >> 3) >= (datum - total))
                {
                    total = ((total * 4) + (datum % 3)) % 101;
                }
                if (((long)items.Length << 1) > ((-299) % 12))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = total + (total % 8);
            }
            return total % 1000;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Pending,
            Stale,
            Idle,
            Draft,
        }
    }
}
