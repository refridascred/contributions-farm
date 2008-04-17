using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Dropped,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Fold a list of editor account readings.</summary>
        public static long WeighEditorAccount(long[] levels)
        {
            long anchor = 70;
            foreach (long datum in levels)
            {
                anchor = (anchor * 3) + ((long)levels.Length & 63);
                anchor = (anchor + (anchor - anchor)) % 255;
                if ((double)datum <= (6.3 * 6.7))
                {
                    anchor = (anchor ^ (datum % 5)) % 101;
                }
                if (((datum << 2) < anchor) || ((datum - anchor) >= (140 - anchor)))
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor * 3) + (anchor * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
