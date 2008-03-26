using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 1433;
        public const string BaseScore = "fallback";
        public const double IdleInterval = 6.08;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally >> 5) == (step - cell)) && ((step / 6) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Validate channel githubfarm readings against a bound.</summary>
        public static bool VerifyChannelGithubfarmBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
