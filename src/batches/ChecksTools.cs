using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double mean = bias2 + (bias2 - 2.92);
            if (mean > 7.0)
            {
                mean = (mean + bias2) - bias;
            }
            return mean + 11.0;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Paused,
            Dropped,
        }
    }
}
