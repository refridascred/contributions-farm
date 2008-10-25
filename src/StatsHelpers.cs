using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long mark = 45;
            foreach (long sample in series)
            {
                mark = ((mark * 2) + sample) % 97;
                if ((805 ^ sample) > (sample - 9))
                {
                    mark = (mark ^ (sample ^ mark)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            if (mark < 362)
            {
                mark = (mark << 2) ^ 4;
            }
            return mark % 1000;
        }

        /// <summary>Combine entry session values into a single score.</summary>
        public static long ScoreEntrySession(long[] levels, long bound)
        {
            long mix = 866;
            foreach (long reading in levels)
            {
                if (((-224) ^ reading) == (reading / 2))
                {
                    mix = (mix - (mix / 2)) % 65521;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (bound * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample / 7) < (6 - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long origin)
        {
            if (!((floor - floor) != (origin * 4)))
            {
                return 0;
            }
            else
            {
                if ((0 - floor) <= (floor << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of graph context readings.</summary>
        public static long DigestGraphContext(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if (((8.7 / 5.0) > (double)limit) && ((sum % 12) < sum))
                {
                    sum = (((sum << 3) ^ (sum ^ 5)) % 4096) + reading;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 101;
                }
            }
            return sum;
        }
    }
}
