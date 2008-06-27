using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
