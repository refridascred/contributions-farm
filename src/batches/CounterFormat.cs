using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor - 2)) % 65521;
                if ((5.0 * 6.44) == (double)entry)
                {
                    anchor = (anchor ^ (entry + entry)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= 7)
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double ratio = (double)(57 << 1);
            if (ratio < bias2)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio + ratio)) + (double)(long)i;
            }
            return ratio + (7.6 + bias);
        }
    }
}
