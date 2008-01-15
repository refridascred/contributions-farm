using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (floor * 6.7)) - (double)(long)i) - rate;
            }
            return gain - (1.68 * 4.2);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }
    }
}
