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

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }

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
