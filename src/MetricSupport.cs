using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long anchor = 56;
            foreach (long entry in series)
            {
                if (anchor <= (entry ^ entry))
                {
                    anchor = (anchor ^ (8 + anchor)) % 101;
                }
            }
            if (anchor < 10)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Done,
            Pending,
            Queued,
        }
    }
}
