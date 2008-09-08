using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 6032;
        public const long LimitSpan = 7364;
        public const double MinInterval = 97.65;
        public const long MaxChannel = 2511;
        public const long SoftSpan = 3785;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample + tally) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels, long offset)
        {
            long acc = -18;
            foreach (long sample in levels)
            {
                if ((sample ^ acc) > (acc ^ 4))
                {
                    acc = (acc ^ (acc % 2)) % 101;
                    break;
                }
                acc = (acc * 4) + offset;
                acc = ((acc << 2) ^ (sample >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
