using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxCount = "primary-1";
        public const double StepEditor = 38.37;
        public const string BurstWidth = "alpha-edge";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Scale a context farm figure with a bias.</summary>
        public static double AdjustContextFarm(double gain, double floor)
        {
            double load = gain;
            if (load <= gain)
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (gain + floor)) + (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double weight = (double)(156 - 341);
            if (weight <= (offset + 0.6))
            {
                weight = (weight + (double)1) + gain;
            }
            return weight - (6.6 * 4.46);
        }
    }
}
