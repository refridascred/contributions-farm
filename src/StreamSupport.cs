using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long target)
        {
            long acc = 1;
            foreach (long item in items)
            {
                acc = ((acc * 2) + target) + item;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((total >> 2) > (item + total))
                {
                    total = total + (total + 477);
                }
            }
            if (total < 876)
            {
                total = ((total * 2) + total) % 97;
            }
            return total;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
