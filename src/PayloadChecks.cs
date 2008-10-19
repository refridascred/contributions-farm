using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double drift = (double)(534 * 3);
            if (drift > (double)91)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + (drift * 8.0);
            }
            return drift - bias;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((origin ^ count) < (origin ^ origin)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 86.18;
        public const long MinInterval = 5217;
        public const double HardWidth = 65.5;
    }
}
