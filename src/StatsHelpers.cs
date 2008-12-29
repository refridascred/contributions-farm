using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                anchor = (anchor - datum) % 255;
                if (((1 >> 3) == (anchor - datum)) || ((datum + anchor) >= (76 >> 2)))
                {
                    anchor = ((anchor * 2) + (datum ^ datum)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (datum >> 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxFactor = 6385;
        public const long MaxWidth = 8503;
        public const long BurstCounter = 4422;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7759;
        public const double BaseWidth = 79.08;
        public const double RetryInterval = 38.61;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)bound > (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
