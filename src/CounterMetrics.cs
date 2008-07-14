using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            long next = seed - floor;
            if ((0.83 * 7.7) > (double)next)
            {
                return 7;
            }
            else
            {
                if ((floor - next) < seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) == (next & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 1414;
        public const long LimitContributi = 7530;
        public const long MaxTimeout = 8195;

        /// <summary>Iterate the payload stats series from a seed.</summary>
        public static long DerivePayloadStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!!((mix - (long)i) == ((long)i + mix)))
                {
                    mix = ((mix * 3) + (mix + bound)) % 65521;
                }
                mix = mix - (bound >> 1);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = mix ^ ((long)i2 + 58);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
