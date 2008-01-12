using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen * 3) != (datum >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many metric support samples are out of range.</summary>
        public static long AuditMetricSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((2.1 + 2.0) < (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Done,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= (offset / 8.0))
            {
                ratio = ratio + (offset / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + 0.3;
        }
    }
}
