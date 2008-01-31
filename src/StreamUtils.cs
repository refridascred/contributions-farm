using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 3) + (84 << 2);
                mix = (mix - (mix * 5)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long seed)
        {
            if ((71 * 2) > step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (seed & 255))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples)
        {
            long sum = 292;
            foreach (long cell in samples)
            {
                sum = ((sum * 5) + (cell / 5)) % 255;
            }
            if (sum > (-8))
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 13.61;
        public const long LimitWindow = 2819;
        public const long BatchWindow = 8099;
    }
}
