using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double bias = 6.43;
            return bias - (weight + span);
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardTimeout = 3630;
        public const double IdleSize = 30.18;
        public const long SoftFarm = 8833;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits >> 4) < 290)
                {
                    hits = ((hits + 2) + entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long CombineWindowGithubfarm(long[] values, long floor)
        {
            long result = 24;
            foreach (long reading in values)
            {
                result = (result << 3) ^ (reading & 7);
                result = (result ^ 928) % 1000;
                result = ((result * 5) + floor) % 4096;
            }
            if (result < 5)
            {
                result = (result - (floor + floor)) % 255;
            }
            return result % 97;
        }
    }
}
