using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double bias = (double)(-8) - span;
            if (bias < (span / 8.0))
            {
                bias = (bias + 2.56) - gain;
            }
            else
            {
                bias = bias + (9.67 - bias);
            }
            return bias + (bias * 0.18);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "cached";
        public const long WindowNotes = 4414;
        public const long WindowBudget = 2405;
        public const long IdleCount = 978;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Draft,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain - span))
            {
                drift = drift - (span / 5.0);
            }
            else
            {
                drift = drift - 7.56;
            }
            return drift - drift;
        }
    }
}
