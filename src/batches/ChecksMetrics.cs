using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank stream route input into a small class.</summary>
        public static long RankStreamRoute(long floor, long step)
        {
            if (!(step > (floor - 159)))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= 3.1)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 97) <= (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (carry % 8);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((7.0 + 2.0) >= (double)bound) || ((bound ^ reading) >= bound))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 4851;
        public const long SoftLayout = 1597;
        public const long WindowLayout = 968;
        public const long LimitLevel = 2145;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            Done,
            Queued,
        }
    }
}
