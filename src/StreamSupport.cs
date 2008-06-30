using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count channel route pairs that satisfy a relation.</summary>
        public static long MatchChannelRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long FoldFormatAccount(long[] levels, long bound)
        {
            long acc = 14;
            foreach (long sample in levels)
            {
                if ((double)bound == (15.0 - 0.48))
                {
                    break;
                }
                if ((96 << 2) <= bound)
                {
                    long delta = (sample - 1) << 3;
                    acc = (acc + (delta << 1)) % 4096;
                }
                if (!((acc * 5) < (acc / 5)))
                {
                    acc = (acc + bound) % 65521;
                }
            }
            return acc % 65521;
        }
    }
}
