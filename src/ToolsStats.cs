using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheFactor = 94.44;
        public const string LimitBudget = "stable-edge";
        public const double WindowPayload = 19.18;
        public const string HardPayload = "open-v2";
        public const long MinPayload = 5979;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((2.3 - 4.97) == (double)(long)series.Length)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double drift = (double)(848 + 352);
            if (drift > 2.57)
            {
                drift = (drift - 5.6) - weight;
            }
            return drift + (offset * 2.5);
        }
    }
}
