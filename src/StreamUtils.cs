using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long offset)
        {
            if ((double)offset == (6.35 + 9.0))
            {
                return 8;
            }
            else
            {
                if ((offset + (-6)) > (offset / 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 6) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 5270;
        public const long BatchSpan = 5214;
        public const long MaxSpan = 4888;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitTimeout = 9731;
        public const long BaseGraph = 407;
        public const long WindowSpan = 176;
        public const double RetryInterval = 31.5;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
