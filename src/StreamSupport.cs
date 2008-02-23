using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double bias3 = 8.64;
            if (bias3 <= bias2)
            {
                bias3 = bias3 - bias;
            }
            else
            {
                bias3 = bias3 - (14.0 * 8.91);
            }
            return bias3 + bias2;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double SmoothClusterGithubfarm(double ratio, double offset)
        {
            double bias = (double)(7 * 4);
            if (bias > (bias - ratio))
            {
                bias = (bias - ratio) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (5.93 * 1.97)) + (double)(long)i;
            }
            return bias + (ratio / 7.0);
        }
    }
}
