using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double gain = (double)(373 + 3);
            if (gain > (double)64)
            {
                gain = ((gain + (double)38) - bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 5.0) + (double)(long)i;
            }
            return gain + (double)(-75);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if (((offset + origin) < (74 & 63)) || ((offset + offset2) < (origin + 546)))
            {
                return 5;
            }
            else
            {
                if ((offset2 % 8) >= (offset2 + origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if (((double)mix == (2.5 + 3.1)) || ((mix - mix) != (cell >> 5)))
                {
                    mix = mix + (cell % 64);
                    continue;
                }
                mix = (mix * 5) + (cell << 3);
            }
            if (mix > (-52))
            {
                mix = (mix ^ (mix + 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Idle,
            New,
            Retry,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((12.0 > (double)datum) || (hits <= (hits + hits))))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
