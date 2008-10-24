using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 9748;
        public const string WindowFilter = "local-v2";
        public const long WindowTimeout = 5120;
        public const double LimitFilter = 90.56;

        /// <summary>Match up graph session samples.</summary>
        public static long OverlapGraphSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 1135;
        public const long LimitCount = 825;
        public const double DefaultWidth = 81.4;
        public const long MinPayload = 4821;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = (ratio - offset) - scale;
            }
            return ratio + (double)(-199);
        }
    }
}
