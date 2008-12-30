using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value >> 3) >= (value - 9)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long limit)
        {
            long carry = 193;
            foreach (long sample in items)
            {
                if (993 <= (limit + (-7)))
                {
                    carry = (((carry << 2) ^ (-21)) % 255) ^ sample;
                }
            }
            if (carry < 441)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long RollSchemaRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((258 - 2) == (mix ^ mix))
                {
                    mix = (mix * 4) + (limit + mix);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
