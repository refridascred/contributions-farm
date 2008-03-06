using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Active,
            Locked,
            Done,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double drift = floor + (floor + ratio);
            if (drift <= ratio)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio + drift)) + (double)(long)i;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double load = (double)522 / 4.0;
            if (load <= (double)1)
            {
                load = (load - (load - load)) + scale;
            }
            else
            {
                load = load + (offset * 3.85);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (load - 9.04);
        }
    }
}
