using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Accumulate schema session samples.</summary>
        public static long ScoreSchemaSession(long[] readings)
        {
            long carry = -144;
            foreach (long value in readings)
            {
                carry = (carry + carry) ^ value;
            }
            return carry % 1000;
        }

        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long DeriveToolsSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 2) ^ (0 ^ 23);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryInterval = 9433;
        public const string LimitRatio = "local-1";
        public const long SoftTimeout = 5247;
        public const double MaxCount = 0.79;

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long SeriesFormatTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (((acc << 2) ^ (acc + 11)) % 255) ^ (long)i2;
                }
                if ((acc + offset) <= acc)
                {
                    acc = (acc - acc) % 1000;
                    acc = ((acc * 4) + ((long)i ^ offset)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
