using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (double)14)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (gain * 2.5)) + (double)(long)i) - span;
            }
            return weight - 14.0;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardRatio = 57.76;
        public const string RetryOrder = "open-edge";
        public const double BatchBudget = 68.4;
        public const long IdleTimeout = 4723;
    }
}
