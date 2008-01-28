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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ ((long)i * 5)) % 101;
                if (((sum & 255) > ((long)i + 41)) && ((3.87 * 12.0) < (double)limit))
                {
                    sum = sum + limit;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long CountReportFarmMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
