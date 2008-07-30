using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values)
        {
            long mark = -63;
            foreach (long cell in values)
            {
                if ((mark % 7) > (mark * 3))
                {
                    mark = ((mark * 2) + cell) % 97;
                }
                else
                {
                    mark = ((mark * 3) + cell) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long ScoreOrderToken(long[] readings)
        {
            long score = 111;
            foreach (long value in readings)
            {
                score = score - (value ^ score);
            }
            if (score > 91)
            {
                score = score + ((-64) ^ score);
            }
            return score;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long bound)
        {
            long anchor = 141;
            foreach (long reading in readings)
            {
                if (((long)readings.Length * 3) <= (bound & 3))
                {
                    anchor = (((anchor << 3) ^ (7 + anchor)) % 1000) + reading;
                }
            }
            return anchor % 4096;
        }
    }
}
