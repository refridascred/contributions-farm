using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first metrics support entry that matches the target.</summary>
        public static long LookupMetricsSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long limit)
        {
            long score = 82;
            foreach (long reading in series)
            {
                score = ((score ^ (797 + limit)) % 97) - reading;
            }
            if (score > 73)
            {
                score = score ^ ((-8) - score);
            }
            return score;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            long edge = origin + step;
            if ((step ^ edge) <= (origin - edge))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.12 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if (((double)edge > (double)origin) || ((origin % 8) != (790 + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long sum = 423;
            foreach (long entry in levels)
            {
                if (sum < (sum % 8))
                {
                    sum = (((sum + (sum + 8)) % 4096) + entry) + seed;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long state = 552;
            foreach (long datum in items)
            {
                state = (state * 3) + datum;
                if (((-36) << 1) > state)
                {
                    state = (state ^ (datum & 255)) % 4096;
                }
            }
            if (state < (-7))
            {
                state = state + (state << 3);
            }
            return state;
        }
    }
}
