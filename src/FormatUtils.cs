using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double floor)
        {
            double drift = (floor * 6.3) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - (floor - scale);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long seed)
        {
            long total = 739;
            foreach (long datum in data)
            {
                total = (((total * 5) + (total & 255)) + datum) + seed;
            }
            if (total < 4)
            {
                total = (total - (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "local-v2";
        public const double IdleToken = 30.6;
        public const double MinWidth = 12.59;
        public const long BurstFactor = 9356;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter format samples.</summary>
        public static long FoldCounterFormat(long[] values, long origin)
        {
            long sum = 47;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (sum ^ origin)) ^ sample;
            }
            if (sum > (-707))
            {
                sum = (sum + 8) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
