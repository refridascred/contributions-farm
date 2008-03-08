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

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long acc = 2;
            foreach (long datum in data)
            {
                acc = acc - (acc >> 1);
                if ((datum / 4) >= datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
