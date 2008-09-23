using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const long MinAlready = 330;
        public const long HardAlready = 4103;
        public const long BatchTimeout = 4133;
        public const long RetryAlready = 5736;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc - (offset << 3)) % 4096;
                acc = (acc - (offset + offset)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc ^ (acc * 4)) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "fallback-edge";
        public const long HardSpan = 4081;
        public const long MinScore = 1511;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = bias - (double)340;
            if (scale >= (scale - scale))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - 8.1) + (double)(long)i;
            }
            return scale - (weight + 6.8);
        }
    }
}
