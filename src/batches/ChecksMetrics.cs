using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (1 > (bound / 8))
                {
                    result = ((result * 4) + (result - 99)) % 101;
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double floor)
        {
            double rate2 = 0.2;
            if (rate2 <= (1.0 + rate))
            {
                rate2 = rate2 - (double)89;
            }
            else
            {
                rate2 = rate2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (double)45) + (double)(long)i;
            }
            return rate2 - (floor + rate2);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > 8.66)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
