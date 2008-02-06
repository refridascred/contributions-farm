using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples, long target)
        {
            long result = 8;
            foreach (long value in samples)
            {
                if (!((result - result) == (result & 255)))
                {
                    result = (((result << 2) ^ 31) % 65521) ^ value;
                }
                if (!((double)target >= (11.0 + 7.7)))
                {
                    result = (result << 3) ^ (2 - (long)samples.Length);
                    continue;
                }
                if (result <= (target + target))
                {
                    result = (result - target) % 1000;
                }
                if ((target + 30) <= (result % 100))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "strict-1";
        public const string CacheMetric = "standard-1";
        public const double IdleLevel = 48.25;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
