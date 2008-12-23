using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultFactor = 771;
        public const string IdleBudget = "cached-edge";
        public const string RetrySpan = "local-1";

        /// <summary>Blend two checks farm measurements.</summary>
        public static double BlendChecksFarm(double weight, double floor)
        {
            double load = (double)(3 * 2);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + load) - (double)(long)i) - floor;
            }
            return load + weight;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit channel entry readings against a rule.</summary>
        public static long AuditChannelEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.7 + 15.0) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long total = 722;
            foreach (long datum in samples)
            {
                if ((datum + datum) < datum)
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = total + 124;
                }
            }
            if (total < 92)
            {
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Rank report batch input into a small class.</summary>
        public static long ClassifyReportBatch(long offset, long target)
        {
            if ((offset / 6) < (-613))
            {
                return 7;
            }
            else
            {
                if (((1.77 - 6.6) == (double)offset) && ((46 - offset) < 627))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
