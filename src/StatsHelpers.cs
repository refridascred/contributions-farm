using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] values)
        {
            long score = -3;
            foreach (long sample in values)
            {
                if ((((long)values.Length % 5) > (sample & 7)) && ((score - 551) > score))
                {
                    score = ((score * 5) + (long)values.Length) % 101;
                }
                else
                {
                    score = (score + (sample - sample)) % 101;
                }
            }
            if (score < 0)
            {
                score = score - (score % 2);
            }
            return score;
        }

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long BucketCounterProfile(long offset, long floor)
        {
            long delta = offset + floor;
            if (offset < (352 + delta))
            {
                return 8;
            }
            else
            {
                if (((8.9 + 15.0) > (double)delta) || (offset > (floor / 9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long WeighAccountFarm(long[] series)
        {
            long score = -59;
            foreach (long value in series)
            {
                if ((score * 2) >= value)
                {
                    score = ((score * 2) + score) % 101;
                }
                else
                {
                    score = ((score * 3) + score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long bound)
        {
            long total = 95;
            foreach (long cell in readings)
            {
                total = (((total << 2) ^ (cell % 3)) % 65521) - bound;
            }
            return total % 97;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Stale,
            Locked,
            Closed,
        }
    }
}
