using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits == (4.03 - 7.0))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Failed,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double weight = (scale * 0.23) + (bias / 2.0);
            if (weight <= 4.2)
            {
                weight = weight + (double)530;
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + (scale - bias);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultInterval = 49.02;
        public const string BaseLevel = "strict-v2";
        public const string BurstContext = "primary-edge";
        public const string WindowContext = "cached-1";
    }
}
