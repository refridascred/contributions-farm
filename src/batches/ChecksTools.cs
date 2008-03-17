using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Closed,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5329;
        public const long BaseSize = 2653;
        public const long DefaultCount = 9874;

        /// <summary>Blend two support metric measurements.</summary>
        public static double ScaleSupportMetric(double gain, double span)
        {
            double ratio = gain;
            if (ratio > (span - gain))
            {
                ratio = ratio - (gain * 8.0);
            }
            else
            {
                ratio = ratio - 7.4;
            }
            return ratio - (gain + ratio);
        }
    }
}
