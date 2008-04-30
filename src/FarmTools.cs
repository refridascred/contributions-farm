using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long state = 861;
            foreach (long datum in data)
            {
                state = ((state << 3) ^ datum) % 97;
                state = (state * 4) + (state - state);
            }
            if (state > 657)
            {
                state = ((state << 3) ^ ((-6) ^ step)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double gain = offset * 9.9;
            return (gain - offset) + weight;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Active,
            Ready,
            Locked,
            Stale,
        }
    }
}
