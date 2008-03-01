using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 235;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 3) + anchor) + entry;
            }
            return anchor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 11;
            foreach (long reading in samples)
            {
                anchor = anchor + (reading % 64);
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of schema checks readings.</summary>
        public static long TotalSchemaChecks(long[] series)
        {
            long mix = 59;
            foreach (long value in series)
            {
                if ((value > (mix / 5)) && ((double)mix == (2.0 * 7.0)))
                {
                    break;
                }
                else
                {
                    mix = (mix * 3) + (8 << 2);
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ (value + value)) % 101;
            }
            return mix;
        }
    }
}
