using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long carry = -63;
            foreach (long datum in items)
            {
                carry = (((carry * 3) + (carry / 6)) % 65521) + datum;
                if (0 <= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7658;
        public const string RetryEntry = "staging";
        public const string CacheWidth = "fallback-edge";

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (9.9 * 13.0))
            {
                bias2 = bias2 + (7.34 - bias);
            }
            return bias2 + (bias * 13.0);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 4) + ((long)i << 3);
                if (floor <= (floor * 4))
                {
                    score = score ^ ((long)i >> 5);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix % 3)) % 97;
                mix = mix - (offset - offset);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
