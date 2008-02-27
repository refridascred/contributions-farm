using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7290;
        public const long DefaultInterval = 7809;
        public const long BaseTools = 7084;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            New,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double ratio = span;
            if (ratio > span)
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + (2.4 + weight);
        }
    }
}
