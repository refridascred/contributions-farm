using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics cache reading.</summary>
        public static double ScaleMetricsCache(double gain, double bias)
        {
            double scale = gain;
            if (scale < scale)
            {
                scale = (scale - (gain + 7.0)) + bias;
            }
            return scale + (double)27;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Paused,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 205;
        public const string HardFilter = "local-1";
        public const long RetryDepth = 465;
        public const long BatchFilter = 1645;
        public const long IdleWidth = 1852;
    }
}
