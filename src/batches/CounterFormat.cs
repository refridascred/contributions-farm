using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((cell >> 2) < hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
