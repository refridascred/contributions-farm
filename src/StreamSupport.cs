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

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (5 + datum)) % 255;
            }
            return mix;
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
