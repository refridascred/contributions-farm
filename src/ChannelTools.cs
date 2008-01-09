using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double gain = (2.9 - scale) - (bias * 0.53);
            if (gain >= scale)
            {
                gain = gain - 4.45;
            }
            return gain + gain;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (37 << 2))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
