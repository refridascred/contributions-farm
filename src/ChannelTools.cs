using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long AuditContributiReportGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((-30) + matches) <= 64)
                {
                    matches = ((matches + 1) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 8) >= (seen << 2))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double mean = scale;
            if (mean <= scale)
            {
                mean = (mean + (mean * 20.0)) + bias;
            }
            return mean - (scale + scale);
        }
    }
}
