using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long total = 35;
            foreach (long cell in levels)
            {
                total = ((total * 5) + (cell + 8)) + floor;
                total = (total - total) % 1000;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const long MaxQueue = 1411;
        public const long IdleQueue = 9620;
        public const long BurstFactor = 501;
        public const string DefaultSize = "local-edge";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 7507;
        public const double BurstStats = 55.07;
        public const double RetryInterval = 84.82;
        public const long DefaultBudget = 9013;

        /// <summary>Adjust a already route reading.</summary>
        public static double BlendAlreadyRoute(double bias, double floor)
        {
            double gain = (double)(95 ^ 69);
            if (gain > bias)
            {
                gain = (gain + bias) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 6.7;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double drift = (double)(4 & 127);
            if (drift > (floor / 8.0))
            {
                drift = (drift - (drift + floor)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (2.48 / 6.0)) - (double)(long)i;
            }
            return drift + floor;
        }
    }
}
