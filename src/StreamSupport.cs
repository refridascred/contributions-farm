using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score ^ (reading + floor);
                score = (score - (1 / 5)) % 65521;
            }
            if (score < 9)
            {
                score = (score - (score - 6)) % 65521;
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (offset < diff)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (5.5 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((diff / 3) < (floor - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
