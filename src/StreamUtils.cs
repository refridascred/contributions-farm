using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = (double)(515 / 4);
            return ((load - (load / 6.0)) + rate) + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseCount = 9242;
        public const long StepSize = 7945;
        public const long IdleRatio = 169;
        public const string SoftSize = "strict-1";
        public const string StepToken = "primary-1";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Draft,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Paused,
            Retry,
            Queued,
        }
    }
}
