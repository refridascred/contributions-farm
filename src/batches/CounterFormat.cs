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

        /// <summary>Roll a entry counter counter forward.</summary>
        public static long StepEntryCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
