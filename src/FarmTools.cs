using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Retry,
            New,
            Synced,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                double scale = (double)(long)i + (3.7 - 3.6);
                if (0.2 > (14.0 - scale))
                {
                    anchor = (anchor - (origin ^ origin)) % 4096;
                }
                scale = scale + scale;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
