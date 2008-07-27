using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a buffer entry counter forward.</summary>
        public static long RollBufferEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ ((long)i + acc)) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = ((mix ^ limit) % 4096) + reading;
            }
            return mix;
        }
    }
}
