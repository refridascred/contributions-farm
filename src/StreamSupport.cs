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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate token cache samples.</summary>
        public static long TallyTokenCache(long[] series, long origin)
        {
            long sum = 92;
            foreach (long reading in series)
            {
                sum = (((sum * 3) + (sum & 3)) % 255) - reading;
                if (origin <= (sum + (-861)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
