using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two commits metrics measurements.</summary>
        public static double SmoothCommitsMetrics(double rate, double span)
        {
            double weight = (rate + span) + (span + span);
            if (weight >= span)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (2.4 - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
