using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings, long limit)
        {
            long carry = 303;
            foreach (long reading in readings)
            {
                if (!((41 <= (reading ^ reading)) && ((double)limit >= (1.0 + 6.7))))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
                if (limit <= (reading >> 4))
                {
                    carry = ((carry << 2) ^ (reading ^ carry)) % 97;
                }
                if ((17.0 + 5.8) != (double)limit)
                {
                    break;
                }
            }
            return carry % 1000;
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
