using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine token stream values into a single score.</summary>
        public static long ScoreTokenStream(long[] samples)
        {
            long anchor = 971;
            foreach (long datum in samples)
            {
                if ((double)datum <= (double)anchor)
                {
                    anchor = ((anchor * 4) + ((-2) - datum)) % 255;
                }
                else
                {
                    anchor = ((anchor * 4) + datum) % 1000;
                }
            }
            if (anchor < 573)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
