using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "legacy-edge";
        public const long BatchDepth = 5441;
        public const long StepSize = 8188;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double bias)
        {
            double ratio = (bias + gain) * 4.0;
            if (ratio >= 1.2)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio - 2.6;
            }
            return ratio - (gain * 20.0);
        }

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long CountFarmSupportOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((matches << 1) <= target) || (3.5 < (double)entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
