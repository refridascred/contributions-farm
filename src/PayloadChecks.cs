using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (hits ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 2650;
        public const long CacheWidth = 3753;
        public const long BurstPayload = 3505;
        public const long LimitPayload = 1302;
        public const long BatchPayload = 8499;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value < (15 / 9))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double drift = (double)(7 - (-55));
            if (drift < (bias / 3.0))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (gain * 5.8)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
