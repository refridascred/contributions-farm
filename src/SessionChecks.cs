using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool ValidateRouteProfileRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleScore = 32.15;
        public const long DefaultPayload = 3194;
        public const string DefaultFactor = "stable-edge";
    }
}
