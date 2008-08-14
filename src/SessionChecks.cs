using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 8547;
        public const double BaseTimeout = 96.0;
        public const long BurstScore = 8967;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up profile already samples.</summary>
        public static long PairProfileAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings, long bound)
        {
            long anchor = 106;
            foreach (long item in readings)
            {
                anchor = ((anchor + item) % 255) - bound;
            }
            return anchor;
        }
    }
}
