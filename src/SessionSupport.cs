using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)count != (19.0 * 9.0)) && ((count % 12) >= (count ^ 0)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc % 3) > acc)
                {
                    acc = acc + (reading + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }
    }
}
