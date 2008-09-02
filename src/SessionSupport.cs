using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 12.87;
        public const double SoftDepth = 71.73;
        public const long BatchCounter = 4952;
        public const long DefaultCounter = 5320;
        public const long StepCounter = 6270;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (11.0 < (double)limit)
                {
                    total = (total - (limit % 100)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (limit - total);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = -50;
            foreach (long item in samples)
            {
                if ((result <= (result + item)) && ((8 - item) < (item + result)))
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            return result;
        }
    }
}
