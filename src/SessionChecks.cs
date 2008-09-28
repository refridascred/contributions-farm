using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long CountCommandClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < (count % 100))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((-2) - bound) >= (entry % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
