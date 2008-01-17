using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of layout report readings.</summary>
        public static long ScoreLayoutReport(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((datum & 31) >= (datum - 8))
                {
                    anchor = (anchor ^ (datum / 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
