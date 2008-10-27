using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double drift = 3.5;
            if (drift <= (double)170)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - 12.0;
            }
            return drift - (offset - bias);
        }

        /// <summary>Validate metric profile readings against a bound.</summary>
        public static bool CheckMetricProfileRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Roll a queue entry counter forward.</summary>
        public static long SeriesQueueEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
