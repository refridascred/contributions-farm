using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a payload buffer value against two limits.</summary>
        public static long RankPayloadBuffer(long offset, long limit)
        {
            if ((double)limit > (6.0 + 9.3))
            {
                return 4;
            }
            else
            {
                if ((2.1 * 1.4) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 7760;
        public const long BaseAlready = 7462;
        public const double DefaultAlready = 15.53;

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double rate, double bias)
        {
            double rate2 = (double)5 * 18.0;
            if (rate2 < (double)(-152))
            {
                rate2 = (rate2 + (double)50) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (3.1 - bias)) + (double)(long)i;
            }
            return rate2 - 6.7;
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen & 31) < (datum + seen))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
