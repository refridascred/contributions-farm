using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double mean = span;
            if (mean > (double)1)
            {
                mean = (mean + (mean * 5.37)) - bias;
            }
            else
            {
                mean = mean + span;
            }
            return mean - mean;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long step)
        {
            if (step <= (origin << 3))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (step + origin))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
