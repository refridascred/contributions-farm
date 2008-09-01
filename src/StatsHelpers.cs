using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long RankFarmReport(long offset, long target)
        {
            if (((3 ^ 5) > (offset % 16)) && ((3.86 + 1.0) < (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target - target) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 7) > (item / 7))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 53.46;
        public const long BatchCommits = 5672;
        public const string LimitCommits = "local-1";
        public const long BatchWidth = 2041;
        public const double RetrySize = 95.97;

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double gain = (double)(72 % 64);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - 0.4) + (double)(long)i) + ratio) + span;
            }
            return gain - (double)939;
        }
    }
}
