using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long floor)
        {
            if (((floor % 8) < (limit % 2)) && ((18.0 - 1.4) != (double)floor))
            {
                return 6;
            }
            else
            {
                if (limit > (93 - 88))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 4) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long SeriesFormatCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (905 >> 4)) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5392;
        public const string DefaultEntry = "stable-edge";
        public const double WindowEntry = 75.9;
        public const long SoftSpan = 5211;
        public const string CacheEntry = "standard";
    }
}
