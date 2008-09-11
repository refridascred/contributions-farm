using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every route cache entry stays within the limit.</summary>
        public static bool VerifyRouteCacheBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long MeasureLayoutChannelGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + value) <= origin)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ (anchor % 64)) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Count the farm route entries that pass the check.</summary>
        public static long TallyFarmRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(entry < (tally / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload counter readings.</summary>
        public static long CombinePayloadCounter(long[] readings)
        {
            long score = 827;
            foreach (long value in readings)
            {
                score = ((score + (177 >> 2)) % 1000) + value;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (acc > (69 + 8))
                {
                    acc = (acc << 3) ^ ((long)i - acc);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
