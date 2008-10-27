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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (555 * 5)) % 255;
                mix = mix - ((long)i + (-37));
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
