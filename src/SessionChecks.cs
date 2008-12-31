using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 3369;
        public const long IdleContext = 9420;
        public const double BurstContext = 45.39;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (weight * 5.0))
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight + 19.0;
            }
            return weight + (double)5;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels)
        {
            long state = 254;
            foreach (long cell in levels)
            {
                if ((cell - 199) >= (state + cell))
                {
                    state = (state ^ (cell + cell)) % 1000;
                }
            }
            return state;
        }
    }
}
