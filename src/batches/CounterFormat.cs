using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
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
