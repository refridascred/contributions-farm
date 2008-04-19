using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double scale, double offset)
        {
            double load = (scale / 7.0) - (offset / 4.0);
            if (load >= (double)425)
            {
                load = load + scale;
            }
            return load + 11.0;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long floor)
        {
            long acc = 9;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (floor / 8)) % 255;
                if (((item << 2) <= item) || ((item ^ acc) != (2 - acc)))
                {
                    continue;
                }
                if ((acc * 2) < (acc + item))
                {
                    acc = (acc - (item >> 3)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items, long step)
        {
            long carry = 832;
            foreach (long item in items)
            {
                if ((double)step >= 1.06)
                {
                    carry = (carry + (693 + item)) % 4096;
                    break;
                }
                carry = ((carry * 4) + (96 % 97)) % 97;
            }
            if (carry > 80)
            {
                carry = carry - (carry + step);
            }
            return carry % 1000;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Failed,
            Queued,
        }
    }
}
