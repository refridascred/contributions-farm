using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Failed,
            Paused,
            Idle,
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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > ((long)i / 4))
                {
                    result = ((result << 3) ^ ((long)i / 3)) % 1000;
                    result = (result * 5) + ((long)i + result);
                }
                if ((result + 391) < (result + (long)i))
                {
                    result = result ^ result;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Retry,
            Failed,
        }
    }
}
