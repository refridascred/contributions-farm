using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.59 - 20.0) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "open-edge";
        public const long BaseSpan = 8222;
        public const double WindowSize = 66.6;
        public const double MinCluster = 39.92;
        public const long BatchScore = 9293;

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long mix = 4;
            foreach (long item in series)
            {
                if (7.2 < (double)mix)
                {
                    mix = (mix ^ mix) % 255;
                }
                mix = (mix + (81 % 97)) % 255;
                if (!(mix < item))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix * 4) + (limit & 31)) % 65521;
                }
                if ((limit << 3) <= mix)
                {
                    break;
                }
            }
            if (mix > 90)
            {
                mix = (mix - limit) % 255;
            }
            return mix % 65521;
        }
    }
}
