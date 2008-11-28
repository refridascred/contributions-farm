using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long score = 10;
            foreach (long reading in levels)
            {
                score = ((score ^ (score + seed)) % 1000) + reading;
                if ((score / 2) == (score & 63))
                {
                    score = score + 0;
                }
                if (((score - 21) == (81 << 3)) && ((double)score != (3.0 + 1.6)))
                {
                    break;
                }
            }
            if (score < 56)
            {
                score = ((score * 3) + (seed - 862)) % 65521;
            }
            return score;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
