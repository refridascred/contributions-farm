using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSize = 6907;
        public const long MaxLevel = 6214;
        public const double BaseCount = 75.29;
        public const long BurstSize = 187;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (17.0 >= (double)tally)
                {
                    tally = ((tally + 3) + item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "local-v2";
        public const double BaseSpan = 0.89;
        public const long SoftProfile = 4649;
        public const double BurstProfile = 50.4;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a schema counter reading by value.</summary>
        public static long LocateSchemaCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
