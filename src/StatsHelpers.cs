using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of format commits entries.</summary>
        public static long WeighFormatCommits(long[] readings, long floor)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                carry = ((carry ^ (433 - floor)) % 65521) + reading;
            }
            return carry;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = acc - ((long)i + (long)i2);
                }
                acc = ((acc << 3) ^ floor) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9819;
        public const double DefaultSpan = 67.04;
        public const string WindowContributi = "legacy-1";
        public const long BaseCount = 1844;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Dropped,
            Stale,
            Draft,
            Ready,
        }
    }
}
