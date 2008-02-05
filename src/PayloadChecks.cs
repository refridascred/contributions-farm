using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of order cluster readings.</summary>
        public static long TotalOrderCluster(long[] series, long origin)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                anchor = (anchor + (reading / 7)) % 1000;
                if (anchor < (-503))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ (origin + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const long MaxQueue = 1411;
        public const long IdleQueue = 9620;
        public const long BurstFactor = 501;
        public const string DefaultSize = "local-edge";

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double rate = scale * 2.6;
            if (rate >= (16.0 - scale))
            {
                rate = rate + (floor - 4.59);
            }
            else
            {
                rate = rate - (double)427;
            }
            return rate - scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 7507;
        public const double BurstStats = 55.07;
        public const double RetryInterval = 84.82;
        public const long DefaultBudget = 9013;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Synced,
            Queued,
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
