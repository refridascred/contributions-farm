using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two record support measurements.</summary>
        public static double SmoothRecordSupport(double scale, double bias)
        {
            double gain = (double)(909 + 15);
            if (gain <= (scale * 18.0))
            {
                gain = (gain - 9.93) + bias;
            }
            return gain - (double)158;
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long AuditCounterProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) > (0 + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)target <= (0.1 + 13.0)) || ((mix * 2) >= (mix + (long)i)))
                {
                    mix = mix + (long)i;
                }
                else
                {
                    mix = mix - ((long)i - (long)i);
                }
                mix = (mix - (mix - (long)i)) % 1000;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
