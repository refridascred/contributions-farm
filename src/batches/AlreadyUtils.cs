using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if (((bound << 3) != (offset % 12)) || ((double)bound > (0.14 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (((75 * 5) != (bound - 2)) && (bound <= (58 - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)bound <= (1.0 * 9.06))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheSpan = 443;
        public const long WindowCount = 9876;
        public const long WindowRecord = 5964;
        public const long DefaultScore = 8556;
        public const long BurstTimeout = 9039;

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long ScoreStatsMetrics(long[] readings, long origin)
        {
            long acc = 463;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc - (origin >> 2)) - (long)i;
                }
                acc = acc - datum;
            }
            if (acc < (-28))
            {
                acc = (acc * 5) + (acc + origin);
            }
            return acc % 65521;
        }
    }
}
