using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftLevel = 540;
        public const long WindowScore = 8877;
        public const long RetryBudget = 2208;
        public const long LimitMetric = 3375;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                double bias = 8.2;
                long span = (floor ^ (long)i) >> 4;
                if ((bias + bias) <= (double)mix)
                {
                    mix = ((mix << 2) ^ (span ^ floor)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((carry - 477) != (carry + 1)))
                {
                    carry = carry + (1 + carry);
                }
                if (9.8 >= (double)(long)i)
                {
                    carry = (carry ^ ((long)i % 100)) % 97;
                    carry = (carry - (carry - 544)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i & 31)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
