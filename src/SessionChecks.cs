using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 4673;
        public const long BurstBuffer = 7851;
        public const string BatchSize = "legacy-edge";
        public const long StepBudget = 3865;
        public const string MaxRatio = "open-1";

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

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value >> 1) > (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
