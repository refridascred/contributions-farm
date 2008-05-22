using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)state < (double)offset))
                {
                    state = state + (state << 2);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state - state) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
