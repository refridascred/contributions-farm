using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i * 2) > target))
                {
                    total = total ^ target;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                mark = (mark + entry) % 1000;
            }
            if (mark < 2)
            {
                mark = (mark ^ (bound << 1)) % 1000;
            }
            return mark;
        }
    }
}
