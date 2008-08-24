using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate batch commits samples.</summary>
        public static long ScoreBatchCommits(long[] series)
        {
            long carry = 712;
            foreach (long reading in series)
            {
                carry = (((carry << 3) ^ (carry % 8)) % 4096) - reading;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double gain = offset;
            return (gain + (3.4 * 9.17)) + scale;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double scale = (double)(5 / 7);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - bias) + (double)(long)i) - gain;
            }
            return scale - (double)796;
        }
    }
}
