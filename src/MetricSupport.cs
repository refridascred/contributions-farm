using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - (bound + 83);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

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
