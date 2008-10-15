using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) == (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                if ((mix << 1) >= (value * 3))
                {
                    mix = (mix ^ value) % 255;
                }
            }
            if (mix < 14)
            {
                mix = (mix << 3) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Draft,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
