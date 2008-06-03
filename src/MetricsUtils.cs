using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double weight = (double)(9 << 1);
            if (weight < (bias / 9.0))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)709;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((offset * 5) > value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long limit)
        {
            long result = -942;
            foreach (long reading in items)
            {
                if (((result / 5) >= (reading % 2)) || (0 <= result))
                {
                    result = (result - reading) % 101;
                }
            }
            if (result < 62)
            {
                result = ((result * 2) + (limit - limit)) % 101;
            }
            return result;
        }
    }
}
