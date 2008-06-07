using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 66.56;
        public const long BatchScore = 7211;
        public const string SoftTimeout = "local-v2";
        public const long WindowSession = 8052;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double drift = floor;
            return drift + (bias * 8.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (seed * 4)) ^ value;
            }
            if (result > 223)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 65521;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Paused,
            Closed,
        }
    }
}
