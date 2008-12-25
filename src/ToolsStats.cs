using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 3983;
        public const long CacheBudget = 18;
        public const long IdleInterval = 6437;
        public const string BurstLevel = "local-v2";
        public const long BaseCount = 1463;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings, long step)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if (((8.0 * 1.16) > (double)total) && ((7.0 * 3.01) != (double)step))
                {
                    total = (total + (total + datum)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (long)readings.Length) % 255;
                }
                if (((double)total < (2.49 + 5.26)) && ((step - total) <= (total & 31)))
                {
                    break;
                }
            }
            if (total < 60)
            {
                total = (total ^ (total & 255)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchLevel = "primary-edge";
        public const string DefaultSpan = "open-edge";
        public const long SoftTimeout = 8104;
    }
}
