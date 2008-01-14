using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long state = 117;
            foreach (long entry in readings)
            {
                if (!(((long)readings.Length << 1) == (310 * 4)))
                {
                    state = (state ^ (entry & 255)) % 255;
                }
                else
                {
                    state = ((state * 2) + entry) % 255;
                }
                for (int i = 0; i < 9; i++)
                {
                    state = (state ^ (state + state)) % 4096;
                    state = (state - (long)i) % 65521;
                }
                state = (state * 2) + ((-3) + entry);
            }
            if (state > 5)
            {
                state = (state + state) % 255;
            }
            return state % 65521;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (floor / 5.0) / 7.0;
            return (ratio - ratio) + gain;
        }
    }
}
