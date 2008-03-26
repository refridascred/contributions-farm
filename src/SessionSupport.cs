using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double drift = scale + (double)284;
            if (drift > 7.71)
            {
                drift = drift - (double)(-17);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (5.8 + bias)) + (double)(long)i;
            }
            return drift - (double)36;
        }
    }
}
