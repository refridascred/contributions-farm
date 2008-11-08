using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double scale = (ratio / 4.0) + (double)632;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Validate route commits readings against a bound.</summary>
        public static bool VerifyRouteCommitsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
