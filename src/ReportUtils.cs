using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length >= (floor * 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5126;
        public const long IdleChecks = 5123;
        public const long MaxFactor = 7797;
        public const double DefaultScore = 76.57;
        public const long WindowChecks = 1745;

        /// <summary>Roll a context farm counter forward.</summary>
        public static long RollContextFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor - (step - step);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = (double)1 / 8.0;
            if (gain > (span - rate))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)85) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
