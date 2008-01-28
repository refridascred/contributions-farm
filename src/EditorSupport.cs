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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Paused,
            New,
            Failed,
            Idle,
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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
