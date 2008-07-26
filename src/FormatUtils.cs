using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitInterval = 1134;
        public const long DefaultCount = 3743;
        public const string CacheSchema = "cached-v2";
        public const string DefaultSchema = "staging-1";
        public const double LimitSchema = 46.73;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 124;
                score = (score + (score / 9)) % 65521;
                if ((score & 7) >= (score + score))
                {
                    score = ((score * 3) + (long)i) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a record checks figure with a bias.</summary>
        public static double BlendRecordChecks(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (16.0 / 6.0))
            {
                bias = (bias - (8.73 - ratio)) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                carry = ((carry << 2) ^ entry) + seed;
                carry = carry ^ (entry / 5);
            }
            return carry % 65521;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Paused,
            Failed,
        }
    }
}
