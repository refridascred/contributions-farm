using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (5.82 + bias))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)764;
            }
            return scale2 - (double)242;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long mix = 60;
            foreach (long sample in readings)
            {
                if (((mix << 1) > (mix ^ offset)) && ((mix ^ 2) > offset))
                {
                    mix = ((mix << 2) ^ (offset ^ mix)) - sample;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Paused,
            Done,
            Closed,
        }
    }
}
