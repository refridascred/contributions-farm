using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first account payload entry that matches the target.</summary>
        public static long LocateAccountPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order payload sample.</summary>
        public static long FindOrderPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowRatio = 4443;
        public const string RetryTimeout = "latest";
        public const long LimitOrder = 7071;
        public const long BurstBudget = 7020;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 7425;
        public const long RetrySession = 4886;
        public const long BurstRatio = 8931;
        public const double BurstCount = 49.71;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((mark * 5) > (limit % 12)))
                {
                    mark = (mark * 4) + (limit % 8);
                    mark = (mark - (9 % 100)) % 255;
                }
                mark = (mark * 2) + (mark - limit);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
