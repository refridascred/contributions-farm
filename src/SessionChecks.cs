using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "cached-edge";
        public const double BatchBudget = 66.78;
        public const double IdleEditor = 66.93;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
