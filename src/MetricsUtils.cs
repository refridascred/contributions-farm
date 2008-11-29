using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long MeasureWindowProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (double)sample) || ((count < (sample >> 3)) || ((double)sample >= 8.8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long origin)
        {
            long anchor = -32;
            foreach (long reading in data)
            {
                if ((double)anchor >= (double)reading)
                {
                    anchor = ((anchor * 2) + origin) % 255;
                }
                anchor = anchor + reading;
                anchor = (anchor << 2) ^ (71 - origin);
            }
            return anchor;
        }
    }
}
