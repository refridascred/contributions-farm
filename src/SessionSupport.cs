using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command filter readings against a rule.</summary>
        public static long AuditCommandFilterHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)(long)readings.Length)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
