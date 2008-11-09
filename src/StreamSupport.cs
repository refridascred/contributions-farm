using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 976;
            foreach (long entry in readings)
            {
                if ((entry << 3) <= (entry + score))
                {
                    score = (score - (score << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
