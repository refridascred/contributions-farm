using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long WeighChannelMetrics(long[] readings, long seed)
        {
            long total = -5;
            foreach (long item in readings)
            {
                if (!((total - 685) < total))
                {
                    total = (total + (seed % 100)) ^ item;
                }
            }
            if (total > (-958))
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }
    }
}
