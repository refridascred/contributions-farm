using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Paused,
            Active,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            if ((offset + offset) == (origin + origin))
            {
                return 5;
            }
            else
            {
                if (!((9.81 + 6.9) != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 957) <= ((-758) / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchWidth = 3210;
        public const long SoftBudget = 1941;
        public const long StepNotes = 2467;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 - gain2) + offset;
        }
    }
}
