using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double span)
        {
            double weight = span;
            if (weight <= (double)242)
            {
                weight = weight - (bias - span);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight * 6.0)) - (double)(long)i;
            }
            return weight - 4.0;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
