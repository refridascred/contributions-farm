using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowSpan = "legacy";
        public const long WindowGraph = 6042;
        public const long MinWidth = 1198;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session schema entries that pass the check.</summary>
        public static long MeasureSessionSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (8.08 + 5.5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
