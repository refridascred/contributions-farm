using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (limit + sum)) % 97;
                if (((sum & 1) >= (sum % 8)) && ((sum & 3) > (limit + sum)))
                {
                    sum = (sum * 3) + ((long)i + (long)i);
                    sum = sum ^ sum;
                }
                sum = sum + (627 + (long)i);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every command metric entry stays within the limit.</summary>
        public static bool ValidateCommandMetricBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context cluster samples.</summary>
        public static long MatchContextClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long limit)
        {
            long gap = origin - limit;
            if ((8.17 * 4.48) <= (double)gap)
            {
                return 2;
            }
            else
            {
                if ((19.0 + 15.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
