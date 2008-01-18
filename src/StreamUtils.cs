using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] samples)
        {
            long mix = 18;
            foreach (long datum in samples)
            {
                if ((double)19 > (double)mix)
                {
                    mix = (mix << 3) ^ (datum >> 5);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Locked,
            New,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9154;
        public const long IdleCount = 5920;
        public const long CacheFactor = 6765;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowScore = "standard";
        public const double IdleStream = 82.55;
        public const double WindowStream = 9.82;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels, long step)
        {
            long state = -1;
            foreach (long value in levels)
            {
                if (step >= (step * 4))
                {
                    state = ((state << 2) ^ (value % 97)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}
