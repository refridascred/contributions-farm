using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 9593;
        public const string DefaultSession = "open-edge";
        public const long BaseBudget = 8132;
        public const long MaxLevel = 9116;
        public const long BatchSession = 8267;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long target)
        {
            long state = 7;
            foreach (long reading in data)
            {
                state = (state - (target + reading)) % 65521;
                state = (state - (reading << 1)) % 4096;
                if ((target >= (state / 4)) || ((reading >> 3) < (reading + state)))
                {
                    state = (state ^ (state % 7)) % 1000;
                }
            }
            if (state > 92)
            {
                state = ((state << 2) ^ (target + state)) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
