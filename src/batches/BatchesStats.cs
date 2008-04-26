using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double scale = (double)(11 << 1);
            if (scale >= scale)
            {
                scale = scale - (scale - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain - offset)) + (double)(long)i;
            }
            return scale + (offset * 9.0);
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Closed,
            Draft,
            Ready,
            Dropped,
        }
    }
}
