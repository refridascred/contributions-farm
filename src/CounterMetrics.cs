using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double gain, double span)
        {
            double ratio = gain;
            if (ratio <= (span / 3.0))
            {
                ratio = ratio + (double)(-85);
            }
            else
            {
                ratio = ratio - 4.26;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (double)4) + (double)(long)i;
            }
            return ratio - (double)95;
        }
    }
}
