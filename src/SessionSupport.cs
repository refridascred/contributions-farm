using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 89.26;
        public const double DefaultScore = 50.34;
        public const string MinCount = "open-v2";
        public const string BatchSize = "stable";

        /// <summary>Measure how many stats window samples are out of range.</summary>
        public static long CountStatsWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((4.3 / 5.0) < (double)matches)
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
