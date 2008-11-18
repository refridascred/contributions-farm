using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long floor)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                acc = (acc - (reading + floor)) % 4096;
            }
            if (acc > 8)
            {
                acc = acc - (acc >> 3);
            }
            return acc;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Paused,
            Queued,
            Dropped,
        }
    }
}
