using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((1.6 * 15.0) < (double)(long)i)
                {
                    result = ((result << 3) ^ 81) % 97;
                    result = (result ^ seed) % 255;
                    break;
                }
                result = (result ^ (seed + result)) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double drift = (double)(65 + 59);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (double)542) + (double)(long)i) - gain;
            }
            return drift - (floor / 6.0);
        }

        /// <summary>Derive the next cluster context value from a seed.</summary>
        public static long SeriesClusterContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
