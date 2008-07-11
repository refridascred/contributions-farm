using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long target)
        {
            if ((1.0 >= (double)target) || ((4.0 / 7.0) < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long sum = 351;
            foreach (long cell in series)
            {
                sum = ((sum - (747 * 2)) % 4096) ^ cell;
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + (sum + offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((step + 8) != (datum << 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitCount = 1526;
        public const double BurstFactor = 80.1;
        public const double WindowRatio = 10.3;

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ step) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
