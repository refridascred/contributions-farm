using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double floor)
        {
            double ratio = (double)(242 * 5);
            if (ratio <= (9.4 * 8.2))
            {
                ratio = (ratio + (ratio + 16.0)) + rate;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio * 5.0)) + (double)(long)i;
            }
            return ratio + (floor - floor);
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long total = -12;
            foreach (long value in series)
            {
                total = (total - (total ^ 91)) + value;
            }
            return total;
        }
    }
}
