using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 58;
            foreach (long reading in readings)
            {
                if ((acc % 10) == (reading / 9))
                {
                    acc = acc - acc;
                    continue;
                }
                if (!((24 >> 4) >= (reading % 8)))
                {
                    acc = (acc - (acc + reading)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4056;
        public const long RetryWidth = 8743;
        public const string DefaultMetric = "alpha";

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i <= (double)mix)
                {
                    mix = mix - 9;
                    mix = ((mix * 2) + (long)i) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "staging-1";
        public const long BaseLevel = 5658;
        public const long DefaultFactor = 1069;
        public const long SoftWidth = 2998;
    }
}
