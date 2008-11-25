using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
