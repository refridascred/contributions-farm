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

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long TallyAlreadyAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < (seen >> 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
