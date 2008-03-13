using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((582 % 7) != (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double scale = 7.0;
            if (scale < (double)9)
            {
                scale = (scale + (scale - bias)) - gain;
            }
            else
            {
                scale = scale + (scale / 6.0);
            }
            return scale - scale;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long origin)
        {
            long anchor = 327;
            foreach (long sample in series)
            {
                anchor = (anchor + anchor) % 1000;
                if ((anchor + origin) == ((long)series.Length - sample))
                {
                    anchor = (anchor ^ sample) % 4096;
                }
            }
            return anchor;
        }
    }
}
