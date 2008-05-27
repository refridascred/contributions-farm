using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate command profile readings against a bound.</summary>
        public static bool GuardCommandProfileRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = acc - (acc << 1);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "primary-v2";
        public const double HardFactor = 51.74;
        public const long BatchLevel = 3592;
        public const long IdleTimeout = 9466;
        public const long IdleAlready = 2877;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
