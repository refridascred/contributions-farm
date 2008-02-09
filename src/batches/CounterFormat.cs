using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6800;
        public const long WindowRatio = 5685;
        public const long LimitChannel = 2956;
        public const long WindowInterval = 2253;
        public const string DefaultBudget = "strict";

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = offset;
            if (drift > offset)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
