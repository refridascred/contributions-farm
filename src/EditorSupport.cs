using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (double)12)
            {
                bias = bias - (floor / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (gain * 4.76)) + (double)(long)i;
            }
            return bias - (double)330;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 56.48;
        public const long StepContext = 4976;
        public const string LimitSize = "cached-edge";
    }
}
