using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (scale / 4.0)) + (double)(long)i;
            }
            return drift + (scale * 19.0);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
