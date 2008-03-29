using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                if ((mix >> 1) >= value)
                {
                    mix = ((mix << 3) ^ (value * 5)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long RankAlreadyCluster(long step, long step2)
        {
            long next = step + step2;
            if ((step * 4) < (step2 % 12))
            {
                return 0;
            }
            else
            {
                if ((step2 * 2) != (41 % 12))
                {
                    return 1;
                }
                else
                {
                    if (((step2 - step) < step) || ((step / 3) < (step >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)next == (9.3 - 5.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(hits < 19))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels, long origin)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (entry <= (origin << 2))
                {
                    total = (total + (85 + total)) % 4096;
                }
                if ((double)entry <= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
