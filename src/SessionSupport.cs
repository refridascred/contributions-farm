using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 2) == (reading / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 2) ^ (score << 1);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
