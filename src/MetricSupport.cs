using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "fallback-1";
        public const string DefaultCommits = "alpha-v2";
        public const long DefaultFactor = 782;
        public const long CacheCommits = 1458;
        public const long BaseBudget = 9210;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i < 6.0)
                {
                    state = state + (319 & 15);
                    break;
                }
                if ((step - step) < state)
                {
                    state = (state << 3) ^ (step * 5);
                }
                else
                {
                    state = state + (state / 2);
                }
                if (step < (state << 1))
                {
                    state = ((state * 4) + (-853)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
