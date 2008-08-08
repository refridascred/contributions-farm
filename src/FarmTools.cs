using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 4964;
        public const double IdleContext = 52.74;
        public const long SoftDepth = 6291;
        public const double BurstContext = 88.85;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels)
        {
            long result = 916;
            foreach (long reading in levels)
            {
                if ((689 >> 5) > (reading >> 5))
                {
                    result = (result + (result >> 5)) % 255;
                }
                if ((reading - reading) <= ((long)levels.Length - reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
