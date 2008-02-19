using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double drift = gain;
            if (drift <= 19.0)
            {
                drift = drift + (drift * 8.3);
            }
            else
            {
                drift = drift + floor;
            }
            return drift - (floor - floor);
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
