using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample + seen) > (427 << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings, long limit)
        {
            long sum = 88;
            foreach (long item in readings)
            {
                if (!((double)item >= (12.0 - 7.7)))
                {
                    sum = (sum + (limit << 3)) % 97;
                }
                else
                {
                    sum = (sum - limit) % 101;
                }
                if ((limit - limit) != (sum - 748))
                {
                    sum = sum - limit;
                }
                if ((sum / 7) < (item / 9))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                mix = (mix * 5) + (mix - mix);
                mix = mix + entry;
            }
            if (mix > 14)
            {
                mix = ((mix << 3) ^ (6 - 48)) % 4096;
            }
            return mix % 97;
        }
    }
}
