using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long ScoreCacheOrder(long[] readings, long target)
        {
            long sum = 52;
            foreach (long item in readings)
            {
                sum = ((((sum * 4) + (sum & 7)) % 101) - item) + target;
            }
            return sum % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 67.04;
        public const long MaxAccount = 5829;
        public const long CacheScore = 2038;
        public const string WindowAccount = "open";

        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally >> 4) == (datum & 3))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch stream entries.</summary>
        public static long TallyBatchStream(long[] values, long step)
        {
            long score = 2;
            foreach (long item in values)
            {
                if (score > (step - score))
                {
                    score = (score ^ (step / 8)) + item;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            return score;
        }

        /// <summary>Count the profile session entries that pass the check.</summary>
        public static long MeasureProfileSessionOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((56 * 2) < (offset + matches)) || (((offset & 15) >= (matches % 8)) || ((item << 3) <= item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
