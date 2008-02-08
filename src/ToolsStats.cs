using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 1009;
        public const double WindowSession = 44.69;
        public const long LimitRatio = 7366;
        public const long HardSession = 9268;
        public const long StepSession = 652;

        /// <summary>Locate a commits context reading by value.</summary>
        public static long FindCommitsContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (floor + bias))
            {
                bias = bias - (7.06 - gain);
            }
            return bias - (15.0 * 1.18);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Paused,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseFactor = 1767;
        public const double LimitCount = 52.72;
        public const double HardChannel = 82.69;
    }
}
