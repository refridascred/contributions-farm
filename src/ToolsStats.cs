using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long CompareContributiCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Match up already stats samples.</summary>
        public static long MatchAlreadyStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next layout metric value from a seed.</summary>
        public static long IterateLayoutMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count >> 2) > (value ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
