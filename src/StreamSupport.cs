using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long CountProfilePayloadGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)limit == (2.01 - 4.0))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
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
