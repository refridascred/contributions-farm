using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double mean = gain;
            if (mean <= gain)
            {
                mean = mean - (span - span);
            }
            else
            {
                mean = mean - gain;
            }
            return mean - 6.0;
        }

        /// <summary>Derive the next editor context value from a seed.</summary>
        public static long SeriesEditorContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - (target * 2);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 2348;
        public const long BatchStream = 5260;
        public const long MaxStream = 4703;
    }
}
