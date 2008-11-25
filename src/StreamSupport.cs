using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series, long floor)
        {
            long acc = 309;
            foreach (long entry in series)
            {
                acc = acc - (entry - floor);
                if ((floor < (acc + entry)) && ((entry * 5) >= entry))
                {
                    acc = (acc + entry) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + total) <= limit)
                {
                    total = ((total << 2) ^ (total % 16)) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
