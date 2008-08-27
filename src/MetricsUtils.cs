using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two channel support measurements.</summary>
        public static double SmoothChannelSupport(double scale, double offset)
        {
            double bias = (scale / 2.0) / 8.0;
            if (bias <= bias)
            {
                bias = bias - (bias - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)59) - (double)(long)i;
            }
            return bias + (scale * 8.81);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double mean = span;
            return (mean - (mean * 13.0)) + bias;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((seed > cell) && ((seed / 9) < (-8)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
