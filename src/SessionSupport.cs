using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Draft,
            Paused,
            Queued,
            Pending,
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
