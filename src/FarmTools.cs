using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up command format samples.</summary>
        public static long PairCommandFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Failed,
            Queued,
        }
    }
}
