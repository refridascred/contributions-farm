using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftCount = 5339;
        public const double HardSize = 48.15;
        public const long LimitInterval = 1969;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings, long limit)
        {
            long result = 37;
            foreach (long reading in readings)
            {
                if ((reading << 2) >= (387 + result))
                {
                    result = ((result << 2) ^ (limit + result)) % 1000;
                }
                else
                {
                    long prev = (reading / 4) + (result + reading);
                    result = (result - prev) % 4096;
                }
                result = (result ^ (738 >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((acc >> 1) > (acc << 3))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
